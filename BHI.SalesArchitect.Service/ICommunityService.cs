using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;
using MvcJqGrid;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunityService
    {
        IEnumerable<GridCommunityResult> GetGridCommunitiesList(int partnerId, string searchTerm, int commStatusType = 0, int commType = 0);
        IEnumerable<Community> GetByCommunityIDs(List<int> communityIds);
    }
}
