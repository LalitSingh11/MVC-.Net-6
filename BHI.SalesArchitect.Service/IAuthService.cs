using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IAuthService
    {
         Task<(bool, User)> Authenticate(string userName, string password);
    }
}
