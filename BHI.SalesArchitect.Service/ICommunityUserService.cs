using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunityUserService
    {
        IEnumerable<CommunityUser> GetByCommunityIDs(List<int> communityIDs);
    }
}
