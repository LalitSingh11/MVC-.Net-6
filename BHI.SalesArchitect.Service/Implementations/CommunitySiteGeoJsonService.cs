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

        public async Task<IEnumerable<CommunitySiteGeoJson>> GetByCommunityIdsAsync(List<int> communityIds)
        {
            return await _communitySiteGeoJsonRepository.GetByCommunityIdsAsync(communityIds);
        }
    }
}
