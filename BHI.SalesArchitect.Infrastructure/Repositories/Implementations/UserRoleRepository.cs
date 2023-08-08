using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private SalesArchitectContext _dbContext;
        public UserRoleRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<UserRole> GetByUserIds(List<int> userIds)
        {
            return _dbContext.UserRoles.Where(x => userIds.Contains(x.Id));
        }
    }
}
