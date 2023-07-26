using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByUserName(string userName);
        Task<User> GetByEmail(string userEmail);
    }
}
