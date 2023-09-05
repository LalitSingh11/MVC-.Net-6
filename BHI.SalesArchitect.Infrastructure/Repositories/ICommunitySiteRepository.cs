using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunitySiteRepository
    {
        Task<IEnumerable<CommunitySite>> GetActiveCommunitySitesAsync(List<int> communityIds);
        
    }
}
