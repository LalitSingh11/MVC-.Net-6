using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IUserService
    {
        Task<User> GetByUsername(string username);
        Task<User> GetById(int id);
        IEnumerable<User> GetCommunityAdminsByCommunityIDs(List<int> communityIDs);
        IEnumerable<User> GetSuperUsers();
    }
}
