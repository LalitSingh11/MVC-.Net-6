using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CommunityUserRepository : ICommunityUserRepository
    {
        private readonly SalesArchitectContext _dbContext;
        public CommunityUserRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CommunityUser>> GetByCommunityIds(List<int> communityIds)
        {
            var result = await _dbContext.CommunityUsers.Where(x => communityIds.Contains(x.CommunityId)).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<CommunityUser>> GetByUserIDs(List<int> userIds)
        {
            var result = await _dbContext.CommunityUsers.Where(x => userIds.Contains(x.UserId)).ToListAsync();
            return result;
        }
    }
}
