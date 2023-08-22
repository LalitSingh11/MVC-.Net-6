using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class ListingService : IListingService
    {
        private IListingRepository _listingRepository;
        public ListingService(IListingRepository listingRepository)
        {
            _listingRepository = listingRepository;
        }
        public IEnumerable<Listing> GetByCommunityId(int communityId)
        {
            return _listingRepository.GetByCommunityId(communityId);
        }

        public IEnumerable<Listing> GetByLotId(int lotId)
        {
            return _listingRepository.GetByLotId(lotId);
        }
    }
}
