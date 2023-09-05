using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunityUserRepository
    {
        Task<IEnumerable<CommunityUser>> GetByCommunityIds(List<int> communityIds);
        Task<IEnumerable<CommunityUser>> GetByUserIDs(List<int> userIds);
    }
}
