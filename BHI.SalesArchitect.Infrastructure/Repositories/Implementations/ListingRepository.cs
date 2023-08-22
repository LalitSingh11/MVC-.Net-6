using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class ListingRepository : IListingRepository
    {
        private SalesArchitectContext _dbContext;
        public ListingRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Listing> GetByCommunityId(int communityId)
        {
            return from l in _dbContext.Listings
                   join bbl in _dbContext.BuilderBrandListings on l.Id equals bbl.ListingId
                   where bbl.CommunityId == communityId
                   select l;
        }

        public IEnumerable<Listing> GetByLotId(int lotId)
        {
            return from l in _dbContext.Listings
                   join ll in _dbContext.LotListings on l.Id equals ll.ListingId
                   where ll.LotId == lotId
                   select l;
        }
    }
}
