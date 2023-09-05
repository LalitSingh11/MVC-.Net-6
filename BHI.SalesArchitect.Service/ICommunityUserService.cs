using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunityUserService
    {
        Task<IEnumerable<CommunityUser>> GetByCommunityIDs(List<int> communityIds);
        Task<IEnumerable<CommunityUser>> GetByUserIds(List<int> userIds);
    }
}
