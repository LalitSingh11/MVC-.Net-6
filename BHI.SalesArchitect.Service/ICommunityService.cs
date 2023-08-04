using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;
using MvcJqGrid;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunityService
    {
        IEnumerable<GridCommunityResult> GetGridCommunitiesList(int partnerId, string searchTerm, int commStatusType, int commType);
        IEnumerable<Community> GetByCommunityIDs(List<int> communityIds);
    }
}
