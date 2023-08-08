using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Infrastructure.Repositories.Implementations;
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

        public Role BHIAdmin => _roleRepository.BHIAdmin;

        public Role PartnerAdmin => _roleRepository.PartnerAdmin;

        public Role PartnerReadOnly => _roleRepository.PartnerReadOnly;

        public Role PartnerSuperAdmin => _roleRepository.PartnerSuperAdmin;

        public Role LotStatusEditor => _roleRepository.LotStatusEditor;

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
