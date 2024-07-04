using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ILotRepository
    {
        IEnumerable<Lot> GetBySiteID(int siteId);
        Task<IEnumerable<Lot>> GetByConfigId(int configId);
        Task<bool> UpdateByLotStateId(int lotStateId);
        Task<IEnumerable<Lot>> GetByCommunityID(int commId);
        IEnumerable<Lot> GetByPartnerID(int partnerId);
        Task<Lot> GetByID(int lotId);
        Task<bool> UpdateLot(Lot lot);
    }
}
