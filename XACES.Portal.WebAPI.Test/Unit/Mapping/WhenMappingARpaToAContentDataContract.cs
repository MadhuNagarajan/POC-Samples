using NUnit.Framework;
using XACES.Portal.Common.Test;
using XACES.Portal.DAL;
using XACES.Portal.WebAPI.DataContracts;
using XACES.Portal.WebAPI.Mapping;

namespace XACES.Portal.WebAPI.Test.Unit.Mapping
{
    [TestFixture]
    [Category(TestCategory.Unit)]
    public class WhenMappingARpaToAContentDataContract
    {
        [SetUp]
        public void Setup()
        {
            Given_A_Rpa();
            When_Mapping_A_Rpa_To_A_Content_Data_Contract();
        }

        private RPA _rpa;
        private IMapper _mapper;
        private ContentDataContract _dataContract;

        private void Given_A_Rpa()
        {
           _rpa = new  RPA
            {
                Content = "Test Content",
                ID = 1
            };
        }

        private void When_Mapping_A_Rpa_To_A_Content_Data_Contract()
        {
            _mapper = new DataContractMapper();
            _dataContract = _mapper.Map(_rpa);
        }

        [Test]
        public void Then_Should_Map_The_Id()
        {
            Assert.That(_dataContract.Id, Is.EqualTo(_rpa.ID));
        }

        [Test]
        public void And_Then_Should_Map_The_Content()
        {
            Assert.That(_dataContract.Content, Is.EqualTo(_rpa.Content));
        }

    }
}
