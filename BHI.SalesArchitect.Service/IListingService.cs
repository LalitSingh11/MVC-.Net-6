using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IListingService
    {
        IEnumerable<Listing> GetByCommunityId(int communityId);
        IEnumerable<Listing> GetByLotId(int lotId);
    }
}
