using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ILotStateService
    {
        Task<IEnumerable<LotState>> GetByPartnerIdAndCommId(int partnerId, int commId);
        Task<IEnumerable<LotState>> GetByConfigId(int configId);
        Task<bool> DeleteByConfigId(int configId);
        Task<IEnumerable<LotState>> GetHoldALotStatusByPartnerIdAndCommId(int partnerId, int commId);
    }
}
