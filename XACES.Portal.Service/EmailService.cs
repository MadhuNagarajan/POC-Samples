using System;
using System.IO;
using System.Text;
using XACES.Portal.Common.Email;
using XACES.Portal.Common.Enums;
using XACES.Portal.Common.ErrorHandling;
using XACES.Portal.Common.Pdf;
using XACES.Portal.DAL;
using Email = XACES.Portal.DAL.Email;

namespace XACES.Portal.Service
{
    public class EmailService : IEmailService
    {
        private const String RpaFileName = "RPA-";
        private const string Subject = "Important information relating to your Tungsten Network Finance agreement.";
        private readonly ILogger _logger;
        private readonly ITokenUserService _tokenservice;
        private readonly IEmail _emailClient;
        private readonly IPdfFileCreator _pdfFileCreator;

        public EmailService(ILogger logger, ITokenUserService tokenservice, IEmail email, IPdfFileCreator pdfFileCreator)
        {
            _logger = logger;
            _tokenservice = tokenservice;
            _emailClient = email;
            _pdfFileCreator = pdfFileCreator;
        }

        /// <summary>
        /// Sends rpa confirmation email and returns true if successfull
        /// </summary>
        public bool SendRpaConfirmationEmailTemplate(string culture, int relationshipId, int tokenUserId, string supplierbuyerDuns, EmailTemplate emailTemplate, RPA rpaAgreement, BankAccount bankAccount)
        {
            var userDetails = _tokenservice.Get(tokenUserId);
            try
            {
                var bodyTemplate = new StringBuilder();

                bodyTemplate.Append(emailTemplate != null ? emailTemplate.Body : "<div>{rows}</div>");

                var accountTemplate = new StringBuilder();
                accountTemplate.Append("<table border=\"1\">");
                if (culture.Equals("en-GB"))
                {
                    accountTemplate.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>",
                        "Bank Name", "Account Number", "Sortcode", "Account Name");
                    accountTemplate.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>",
                        bankAccount.BankName, bankAccount.AccountNumber, bankAccount.Sortcode, bankAccount.AccountName);
                }
                else
                {
                    accountTemplate.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>",
                       "Bank Name", "Account Number", "BIC", "IBAN","Account Name");
                    accountTemplate.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>",
                        bankAccount.BankName, bankAccount.AccountNumber, bankAccount.BIC, bankAccount.IBAN, bankAccount.AccountName);
                }
                accountTemplate.Append("</table>");

                bodyTemplate = bodyTemplate.Replace("{rows}", accountTemplate.ToString());

                var contentCreated = false;
                var rpaPdf = string.Empty;

                try
                {
                    rpaPdf = _pdfFileCreator.Create(rpaAgreement.Content, string.Concat(RpaFileName, supplierbuyerDuns));
                    contentCreated = true;
                }
                catch (Exception ex)
                {
                    _logger.LogMessage(string.Format("Pdf creation error for tokenuserid: {0}.", tokenUserId), ex, Enumerations.EventCode.ERROR);
                }

                using (var context = new XACESPortalEntities())
                {
                    var email = new Email();
                    var subject = emailTemplate == null ? Subject : emailTemplate.Subject;
                    if (contentCreated && _emailClient.SendSmtpEmail(userDetails.UserName,
                            userDetails.FirstName + " " + userDetails.LastName, subject, bodyTemplate.ToString(),
                            rpaPdf))
                    {
                        email.EmailState_ID = (int) EmailStateType.Sent;
                    }
                    else
                    {
                        email.EmailState_ID = (int) EmailStateType.Failed;
                    }

                    email.CreatedOn = DateTime.UtcNow;
                    email.BankAccount_ID = bankAccount.ID;
                    email.TokenUser_ID = tokenUserId;
                    email.RpaAttachment = rpaAgreement.Content;
                    email.EmailId = userDetails.UserName;

                    context.Emails.Add(email);
                    context.SaveChanges();
                }

                if (contentCreated)
                {
                    if(File.Exists(rpaPdf))
                    {
                        File.Delete(rpaPdf);
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogMessage(string.Format("Error when sending email for tokenuserid: {0}.", tokenUserId), ex, Enumerations.EventCode.ERROR);

            }
            return true;
        }
    }
}
