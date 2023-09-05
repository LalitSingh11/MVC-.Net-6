using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CommunitySiteGeoJsonRepository : ICommunitySiteGeoJsonRepository
    {
        private readonly SalesArchitectContext _dbContext;
        public CommunitySiteGeoJsonRepository(SalesArchitectContext db)
        {
            _dbContext = db;
        }

        public async Task<IEnumerable<CommunitySiteGeoJson>> GetByCommunityIdsAsync(List<int> communityIds)
        {
            return await _dbContext.CommunitySiteGeoJsons.Where(x => communityIds.Contains(x.Id) && x.ActivityStateId == 1).ToListAsync();
        }
    }
}
