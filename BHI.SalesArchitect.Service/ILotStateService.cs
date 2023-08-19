using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ILotStateService
    {
        IEnumerable<LotState> GetByPartnerId(int partnerId);
    }
}
