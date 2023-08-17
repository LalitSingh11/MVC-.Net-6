using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByUserName(string userName);
        Task<User> GetByEmail(string userEmail);
        Task<User> GetById(int id);
        IEnumerable<User> GetCommunityAdminsByCommunityID(List<int> communityIDs);
        IEnumerable<User> GetSuperUsers();
        Task<bool> UpdateUser(User user);
        Task<bool> AddUser(User user);
        Task<bool> DeleteUser(User user);
    }
}
