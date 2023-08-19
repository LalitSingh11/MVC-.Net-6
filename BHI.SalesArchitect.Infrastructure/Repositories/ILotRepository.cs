using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ILotRepository
    {
        IEnumerable<Lot> GetBySiteID(int siteId);
        IEnumerable<Lot> GetByCommunityID(int commId);
        IEnumerable<Lot> GetByPartnerID(int partnerId);
        Lot GetByID(int lotId);
    }
}
