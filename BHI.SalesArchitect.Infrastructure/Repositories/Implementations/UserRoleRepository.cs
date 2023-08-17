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

        public async Task<bool> AddUserRole(UserRole userRole)
        {
            _dbContext.UserRoles.Add(userRole);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteUserRole(UserRole userRole)
        {
            _dbContext.UserRoles.Remove(userRole);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public UserRole GetByUserId(int userId)
        {
            return _dbContext.UserRoles.Where(x => x.UserId == userId).FirstOrDefault();
        }

        public IEnumerable<UserRole> GetByUserIds(List<int> userIds)
        {
            return _dbContext.UserRoles.Where(x => userIds.Contains(x.UserId));
        }

        public async Task<bool> UpdateUserRole(UserRole userRole)
        {
            _dbContext.UserRoles.Update(userRole);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
