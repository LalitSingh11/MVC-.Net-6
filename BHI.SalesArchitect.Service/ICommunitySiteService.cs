using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunitySiteService
    {
        Task<IEnumerable<CommunitySite>> GetActiveCommunitySitesAsync(List<int> communityIds);
    }
}
