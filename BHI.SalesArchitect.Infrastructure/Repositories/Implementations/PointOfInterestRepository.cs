using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        private SalesArchitectContext _dbContext;
        public PointOfInterestRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<PointOfInterest> GetAll()
        {
            return _dbContext.PointOfInterests.ToList();
        }

        public async Task<IEnumerable<PointOfInterest>> GetByCommunityId(int commId, bool isGeospatial = false)
        {
            var result = from poi in _dbContext.PointOfInterests
                         join cpoi in _dbContext.CommunityPointOfInterests on poi.Id equals cpoi.PointOfInterestId
                         where cpoi.CommunityId == commId && cpoi.IsGeospatial == isGeospatial
                         select poi;
            return await result.ToListAsync();
        }
    }
}
