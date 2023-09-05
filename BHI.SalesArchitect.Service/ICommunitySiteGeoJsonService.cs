using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunitySiteGeoJsonService
    {
        Task<IEnumerable<CommunitySiteGeoJson>> GetByCommunityIdsAsync(List<int> communityIds);
    }
}
