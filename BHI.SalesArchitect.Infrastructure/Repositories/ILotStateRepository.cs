using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ILotStateRepository
    {
        IEnumerable<LotState> GetByPartnerId(int partnerId);
    }
}
