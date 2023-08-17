using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ILotRepository
    {
        IEnumerable<Lot> GetBySiteID(int? siteID);
        IEnumerable<Lot> GetByCommunityID(int? commID);
        IEnumerable<Lot> GetByPartnerID(int? partnerID);
    }
}
