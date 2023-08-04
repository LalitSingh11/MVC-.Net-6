using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunitySiteGeoJsonService
    {
        IEnumerable<CommunitySiteGeoJson> GetByCommunityIds(List<int> communityids);
    }
}
