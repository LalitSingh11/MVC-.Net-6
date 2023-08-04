using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunitySiteGeoJsonRepository
    {
        IEnumerable<CommunitySiteGeoJson> GetByCommunityIds(List<int> communityIds);
    }
}
