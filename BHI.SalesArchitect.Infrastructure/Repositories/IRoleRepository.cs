using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role GetByCode(string code);
        Role GetByUserId(int userId);
        Role GetByUserName(string userName);
        Role BHIAdmin { get; }
        Role PartnerAdmin { get; }
        Role PartnerReadOnly { get; }
        Role PartnerSuperAdmin { get; }
        Role LotStatusEditor { get; }
    }
}
