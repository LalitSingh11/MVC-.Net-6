using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunitySiteRepository
    {
        Task<IEnumerable<CommunitySite>> GetActiveCommunitySites(List<int> communityIds);
        Task<CommunitySite> GetByCommunityId(int communityId);

        
    }
}
