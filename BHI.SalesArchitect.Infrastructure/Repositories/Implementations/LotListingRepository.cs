using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class LotListingRepository : ILotListingRepository
    {
        private readonly SalesArchitectContext _dbContext;
        public LotListingRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddLotListings(List<LotListing> lotListings)
        {
            _dbContext.LotListings.AddRange(lotListings);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteLotListingsByLotId(int lotId)
        {
            var lotsToDelete = _dbContext.LotListings.Where(row => row.LotId == lotId);
            _dbContext.LotListings.RemoveRange(lotsToDelete);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public IEnumerable<LotListing> GetByLotId(int lotId)
        {
            return from ll in _dbContext.LotListings
                   where ll.LotId == lotId
                   select ll;
        }
    }
}
