using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IRoleService
    {
        Role GetByUsername(string username);
        Role GetByUserId(int userId);

    }
}
