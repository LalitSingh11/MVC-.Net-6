using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunitySiteRepository
    {
        IEnumerable<CommunitySite> GetActiveCommunitySites(List<int> communityIds);
        
    }
}
