using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ILotStateRepository
    {
        Task<IEnumerable<LotState>> GetByPartnerId(int partnerId);
        Task<IEnumerable<LotState>> GetByConfigId(int configId);
        Task<bool> DeleteByConfigId(int configId);
    }
}
