using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunityUserService
    {
        Task<IEnumerable<CommunityUser>> GetByCommunityIDs(List<int> communityIds);
        Task<IEnumerable<CommunityUser>> GetByUserIds(List<int> userIds);
        Task<bool> UpdateByUserId(int userId, List<int> commIds);
        Task<bool> AddByUserId(int userId, List<int> commIds);
        Task<bool> DeleteByUserId(int userId);
    }
}
