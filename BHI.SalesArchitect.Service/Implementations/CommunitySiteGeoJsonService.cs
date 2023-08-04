using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CommunitySiteGeoJsonService : ICommunitySiteGeoJsonService
    {
        private readonly ICommunitySiteGeoJsonRepository _communitySiteGeoJsonRepository;
        public CommunitySiteGeoJsonService(ICommunitySiteGeoJsonRepository communitySiteGeoJsonRepository)
        {
            _communitySiteGeoJsonRepository = communitySiteGeoJsonRepository;
        }

        public IEnumerable<CommunitySiteGeoJson> GetByCommunityIds(List<int> communityIds)
        {
            return _communitySiteGeoJsonRepository.GetByCommunityIds(communityIds);
        }
    }
}
