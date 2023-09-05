using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunitySiteGeoJsonRepository
    {
        Task<IEnumerable<CommunitySiteGeoJson>> GetByCommunityIdsAsync(List<int> communityIds);
    }
}
