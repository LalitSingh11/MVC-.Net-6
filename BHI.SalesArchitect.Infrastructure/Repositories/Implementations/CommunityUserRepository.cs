using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CommunityUserRepository : ICommunityUserRepository
    {
        private readonly SalesArchitectContext _dbContext;
        public CommunityUserRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CommunityUser> GetByCommunityIDs(List<int> communityIDs)
        {
            var result = _dbContext.CommunityUsers.Where(x => communityIDs.Contains(x.CommunityId)).ToList();
            return result;
        }
    }
}
