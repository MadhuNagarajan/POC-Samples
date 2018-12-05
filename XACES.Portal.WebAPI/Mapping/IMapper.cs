using System.Collections.Generic;
using XACES.Portal.DAL;
using XACES.Portal.DAL.Views;
using XACES.Portal.WebAPI.DataContracts;
using XACES.Portal.WebAPI.DataContracts.Rpas;
using XACES.Portal.WebAPI.DataContracts.Terms;
using XACES.Portal.WebAPI.DataContracts.Token;

namespace XACES.Portal.WebAPI.Mapping
{
    public interface IMapper
    {
        TokenDataContract Map(TokenUser src);
        TokenUser Map(TokenUserDataContract src);
        CompanyDetailsDataContract Map(WorldBase1784 src);
        List<ExecutiveDataContract> Map(Executive src);
        RpaDataContract Map(List<BuyerRelationship> src);
        ContentDataContract Map(Datawaiver src);
        SupplierBankAccount Map(SupplierBankAccountDataContract src);
        ContentDataContract Map(RPA src);
    }
}