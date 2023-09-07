using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class ProspectCommunityRepository : IProspectCommunityRepository
    {
        private readonly SalesArchitectContext _dbContext;
        public ProspectCommunityRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> DeleteByUserId(int userId)
        {
            var prospectCommunity = _dbContext.ProspectCommunities.Where(x => x.UserId == userId);
            _dbContext.ProspectCommunities.RemoveRange(prospectCommunity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<ProspectCommunity>> GetByUserId(int userId)
        {
            return await _dbContext.ProspectCommunities.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
