using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunityRepository
    {
        IEnumerable<GridCommunityResult> GetProcDataByPartnerId(int partnerId);
        Task<IEnumerable<Community>> GetByCommunityIds(List<int> communityIds);
        Task<IEnumerable<Community>> GetByPartnerIdAndByUserId(int partnerId, int userId);
        Task<IEnumerable<Community>> GetCommunitiesByPartnerId(int partnerId);

    }
}
