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

        public async Task<bool> AddCommunityUser(List<CommunityUser> communityUsers)
        {
            await _dbContext.CommunityUsers.AddRangeAsync(communityUsers);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteByUserId(int userId)
        {
            var existingCommUsers = _dbContext.CommunityUsers.Where(x => x.UserId == userId);
            _dbContext.CommunityUsers.RemoveRange(existingCommUsers);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<CommunityUser>> GetByCommunityIds(List<int> communityIds)
        {
            return await _dbContext.CommunityUsers.Where(x => communityIds.Contains(x.CommunityId)).ToListAsync();            
        }

        public async Task<IEnumerable<CommunityUser>> GetByUserIDs(List<int> userIds)
        {
            return await _dbContext.CommunityUsers.Where(x => userIds.Contains(x.UserId)).ToListAsync();            
        }
    }
}
