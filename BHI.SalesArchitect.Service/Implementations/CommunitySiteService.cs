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
        public IEnumerable<CommunitySite> GetActiveCommunitySites(List<int> communityIds)
        {
            return _communitySiteRepository.GetActiveCommunitySites(communityIds);
        }
    }
}
