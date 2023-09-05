using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunityService
    {
        IEnumerable<GridCommunityResult> GetGridCommunitiesList(int partnerId, string searchTerm, int commStatusType = 0, int commType = 0);
        Task<IEnumerable<Community>> GetByCommunityIds(List<int> communityIds);
        Task<IEnumerable<Community>> GetByPartnerIdAndByUserId(int partnerId, int userId);
        Task<IEnumerable<Community>> GetCommunitiesByPartnerId(int partnerId);
    }
}
