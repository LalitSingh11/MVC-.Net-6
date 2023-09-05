using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CommunitySiteService : ICommunitySiteService
    {
        private ICommunitySiteRepository _communitySiteRepository;
        public CommunitySiteService(ICommunitySiteRepository communitySiteRepository)
        {
            _communitySiteRepository = communitySiteRepository;
        }
        public async Task<IEnumerable<CommunitySite>> GetActiveCommunitySitesAsync(List<int> communityIds)
        {
            return await _communitySiteRepository.GetActiveCommunitySitesAsync(communityIds);
        }
    }
}
