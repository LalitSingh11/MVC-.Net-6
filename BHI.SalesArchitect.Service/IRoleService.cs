using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IRoleService
    {
        Role GetByUsername(string username);
        Role GetByUserId(int userId);
        Role BHIAdmin { get; }
        Role PartnerAdmin { get; }
        Role PartnerReadOnly { get; }
        Role PartnerSuperAdmin { get; }
        Role LotStatusEditor { get; }

    }
}
