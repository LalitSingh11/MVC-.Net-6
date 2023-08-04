using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunityUserRepository
    {
        IEnumerable<CommunityUser> GetByCommunityIDs(List<int> communityIDs);
    }
}
