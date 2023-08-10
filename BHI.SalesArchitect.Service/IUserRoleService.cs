using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IUserRoleService
    {
        IEnumerable<UserRole> GetByUserIds(List<int> userIds);
        UserRole GetByUserId(int userId);
        Task<bool> UpdateUserRole(int userId, int roleId);  
    }
}
