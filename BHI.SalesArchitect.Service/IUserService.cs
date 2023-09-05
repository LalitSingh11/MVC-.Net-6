using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IUserService
    {
        Task<User> GetByUsername(string username);
        Task<User> GetById(int id);
        Task<IEnumerable<User>> GetCommunityAdminsByCommunityIDs(List<int> communityIDs);
        Task<IEnumerable<User>> GetByPartnerIdExcludingRoles(int partnerId, List<int> roleIds);
        Task<IEnumerable<User>> GetByPartnerIDAndCommunityUser(int partnerId, int userId, List<int> roleIds, int activityStateId);
        Task<IEnumerable<User>> GetSuperUsers();
        Task<bool> UpdateUser(User user);
        Task<bool> AddUser(User user);
        Task<bool> DeleteUser(int id);
    }
}
