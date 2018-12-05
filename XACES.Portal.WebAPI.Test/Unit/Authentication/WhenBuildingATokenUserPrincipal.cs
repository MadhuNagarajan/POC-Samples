using System.Security.Principal;
using NUnit.Framework;
using XACES.Portal.Common.Test;
using XACES.Portal.DAL;
using XACES.Portal.WebAPI.Authentication;

namespace XACES.Portal.WebAPI.Test.Unit.Authentication
{
    [TestFixture]
    [Category(TestCategory.Unit)]
    public abstract class WhenBuildingATokenUserPrincipal
    {
        [SetUp]
        public void Setup()
        {
            Given_A_Token_User();
            When_Building_A_Token_User_Principal();
        }

        protected IPrincipal Principal;
        protected TokenUserPrincipal TokenUserPrincipal;
        protected TokenUser TokenUser;

        protected abstract void Given_A_Token_User();

        protected abstract void When_Building_A_Token_User_Principal();
    }
}