using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CommunitySiteRepository : ICommunitySiteRepository
    {
        private SalesArchitectContext _dbContext;
        public CommunitySiteRepository(SalesArchitectContext dbContext)
        {

            _dbContext = dbContext;

        }
        public async Task<IEnumerable<CommunitySite>> GetActiveCommunitySitesAsync(List<int> communityIds)
        {
            var query = from cs in _dbContext.CommunitySites
                        join s in _dbContext.Sites on cs.SiteId equals s.Id
                        where communityIds.Contains(cs.CommunityId) && s.MapData != null
                        select cs;
            return await query.ToListAsync();
        }
    }
}
