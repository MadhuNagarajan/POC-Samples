using XACES.Portal.DAL;

namespace XACES.Portal.Service
{
    public interface IEmailService
    {
        /// <summary>
        /// Sends rpa confirmation email and returns true if successfull
        /// </summary>
        bool SendRpaConfirmationEmailTemplate(string culture, int relationshipId, int tokenUserId, string supplierbuyerDuns, EmailTemplate emailTemplate,
            RPA rpaAgreement, BankAccount bankAccount);
    }
}
