using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByUserName(string userName);
        Task<User> GetByEmail(string userEmail);
        Task<User> GetById(int id);
        Task<IEnumerable<User>> GetCommunityAdminsByCommunityID(List<int> communityIDs);
        Task<IEnumerable<User>> GetByPartnerIdExcludingRoles(int partnerId, List<int> roleIds);
        Task<IEnumerable<User>> GetByPartnerIdAndCommunityUser(int partnerId, int userId, List<int> roleIds, int activityStateId);
        Task<IEnumerable<User>> GetSuperUsers();
        Task<bool> UpdateUser(User user);
        Task<bool> AddUser(User user);
        Task<bool> DeleteUser(User user);
    }
}
