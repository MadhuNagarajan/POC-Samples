using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using XACES.Portal.Common.Test;
using XACES.Portal.DAL.Views;
using XACES.Portal.WebAPI.DataContracts.Rpas;
using XACES.Portal.WebAPI.Mapping;

namespace XACES.Portal.WebAPI.Test.Unit.Mapping
{
    [TestFixture]
    [Category(TestCategory.Unit)]
    public class WhenMappingASupplierToARpaDataContract
    {
        [SetUp]
        public void Setup()
        {
            Given_Supplier_Data();
            When_Mapping_A_Supplier_To_A_RpaDataContract();
        }

        private RpaDataContract _rpaDataContract;
        private List<BuyerRelationship> _buyerRelationships;

        private void Given_Supplier_Data()
        {
            _buyerRelationships =
                new List<BuyerRelationship>
                {
                    new BuyerRelationship {IndicativeRate = 0.21M, BuyerName = "Test Company 1"},
                    new BuyerRelationship {IndicativeRate = 0.03M, BuyerName = "Test Company 2"}
                };

        }

        private void When_Mapping_A_Supplier_To_A_RpaDataContract()
        {
            var mapper = new DataContractMapper();
            _rpaDataContract = mapper.Map(_buyerRelationships);
        }

        [Test]
        public void Then_Should_Contain_The_Correct_Number_Of_Buyers()
        {
            Assert.That(_rpaDataContract.Buyers.Count, Is.EqualTo(2));
        }


        [TestCase("Test Company 1")]
        [TestCase("Test Company 2")]
        public void And_Then_Should_Contain_The_Correct_Buyer_Company(string name)
        {
            Assert.That(_rpaDataContract.Buyers.FirstOrDefault(x => x.BuyerCompanyName.Equals(name)), Is.Not.Null);
        }

        [TestCase(0.21)]
        [TestCase(0.03)]
        public void And_Then_Should_Contain_The_Correct_Buyer_Indicative_Rates(decimal rate)
        {
            Assert.That(_rpaDataContract.Buyers.FirstOrDefault(x => x.IndicativeRate.Equals(rate)), Is.Not.Null);
        }
    }
}