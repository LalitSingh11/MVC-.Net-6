using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class RoleService : IRoleService
    {
        private IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository) 
        {
            _roleRepository = roleRepository;
        }

        public Role GetByUserId(int userId)
        {
            return _roleRepository.GetByUserId(userId);
        }

        public Role GetByUsername(string username)
        {
            return _roleRepository.GetByUserName(username);
        }
    }
}
