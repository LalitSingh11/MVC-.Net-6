using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class UserRoleService : IUserRoleService
    {
        private IUserRoleRepository _userRoleRepository;
        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }

        public IEnumerable<UserRole> GetByUserIds(List<int> userIds)
        {
            return _userRoleRepository.GetByUserIds(userIds).ToList();
        }
    }
}
