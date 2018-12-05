
using Moq;
using NUnit.Framework;
using XACES.Portal.Common.Authentication;
using XACES.Portal.Common.Test;
using XACES.Portal.WebAPI.Authentication;
using XACES.Portal.WebAPI.Configuration;

namespace XACES.Portal.WebAPI.Test.Unit.Authentication
{
    [TestFixture]
    [Category(TestCategory.Unit)]
    public abstract class WhenAuthenticatingAClientWebApiUser
    {
        protected bool IsValid;
        protected Mock<IWebApiAppSettings> MockWebApiAppSettings;
        protected string Username;
        protected string Password;
        protected IUserAuthenticator Authenticator;
            
        [SetUp]
        public void Setup()
        {
            Given_An_User();
            When_Authenticating_A_Client_WebApi_User();
        }

        protected abstract void Given_An_User();

        protected virtual void When_Authenticating_A_Client_WebApi_User()
        {
            Authenticator = new UserAuthenticator(MockWebApiAppSettings.Object);
            IsValid = Authenticator.IsValid(Username, Password,true);
        }

    }

}