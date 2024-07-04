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
        public async Task<IEnumerable<CommunitySite>> GetActiveCommunitySites(List<int> communityIds)
        {
            var query = from cs in _dbContext.CommunitySites
                        join s in _dbContext.Sites on cs.SiteId equals s.Id
                        where communityIds.Contains(cs.CommunityId) && s.MapData != null
                        select cs;
            return await query.ToListAsync();
        }

        public async Task<CommunitySite> GetByCommunityId(int communityId)
        {
            return await _dbContext.CommunitySites.Where(x => x.CommunityId ==  communityId).FirstOrDefaultAsync();
        }
    }
}
