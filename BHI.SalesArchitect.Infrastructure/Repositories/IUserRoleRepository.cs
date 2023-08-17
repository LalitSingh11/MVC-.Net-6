using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IUserRoleRepository
    {
        IEnumerable<UserRole> GetByUserIds(List<int> userIds);
        UserRole GetByUserId(int userId);
        Task<bool> UpdateUserRole(UserRole userRole);
        Task<bool> AddUserRole(UserRole userRole);
        Task<bool> DeleteUserRole(UserRole userRole);
    }
}
