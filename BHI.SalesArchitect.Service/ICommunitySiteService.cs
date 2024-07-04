using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunitySiteService
    {
        Task<IEnumerable<CommunitySite>> GetActiveCommunitySites(List<int> communityIds);
        Task<CommunitySite> GetByCommunityId(int communityId);
    }
}
