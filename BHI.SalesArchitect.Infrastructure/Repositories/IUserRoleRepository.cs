using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IUserRoleRepository
    {
        IEnumerable<UserRole> GetByUserIds(List<int> userIds);
    }
}
