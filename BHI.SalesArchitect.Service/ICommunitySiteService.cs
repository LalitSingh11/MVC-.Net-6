using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunitySiteService
    {
        IEnumerable<CommunitySite> GetActiveCommunitySites(List<int> communityIds);
    }
}
