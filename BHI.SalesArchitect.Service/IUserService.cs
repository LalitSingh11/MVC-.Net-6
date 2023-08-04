using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IUserService
    {
        Task<User> GetByUsernameAsync(string username);
        IEnumerable<User> GetCommunityAdminsByCommunityIDs(List<int> communityIDs);
    }
}
