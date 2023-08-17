using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IUserService
    {
        Task<User> GetByUsername(string username);
        Task<User> GetById(int id);
        List<User> GetCommunityAdminsByCommunityIDs(List<int> communityIDs);
        List<User> GetSuperUsers();
        Task<bool> UpdateUser(User user);
        Task<bool> AddUser(User user);
        Task<bool> DeleteUser(int id);
    }
}
