using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CommunityService : ICommunityService
    {
        private ICommunityRepository _communityRepository;
        private ISessionService _sessionService;

        public CommunityService(ICommunityRepository communityRepository,
            ISessionService sessionService)
        {
            _communityRepository = communityRepository;
            _sessionService = sessionService;
        }

        public IEnumerable<Community> GetByCommunityIDs(List<int> communityIds)
        {
            return _communityRepository.GetByCommunityIDs(communityIds);
        }

        public IEnumerable<GridCommunityResult> GetGridCommunitiesList(int partnerId, string searchTerm, int commStatusType = 0, int commType = 0)
        {
            var communities = _communityRepository.GetProcDataByPartnerId(partnerId);
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.Trim();
                communities = communities
                    .Where(x => x.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                x.Brand.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            switch (commType)
            {
                case 0:
                    communities = communities.Where(x => x.Bdxid != 0).ToList();
                    break;
                case 1:
                    communities = communities.Where(x => x.Bdxid == 0).ToList();
                    break;
            }
            switch (commStatusType)
            {
                case 0:
                    communities = communities.Where(x => x.DeletedBy == null || x.DeletedBy == "" || x.DateDeleted == null || x.DateDeleted == DateTime.MinValue).ToList();
                    break;
                case 1:
                    communities = communities.Where(x => x.DeletedBy != null && x.DeletedBy != "" && x.DateDeleted != null && x.DateDeleted != DateTime.MinValue).ToList();
                    break;
            }
            return communities;
        }
    }
}
