using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CommunityService : ICommunityService
    {
        private ICommunityRepository _communityRepository;

        public CommunityService(ICommunityRepository communityRepository)
        {
            _communityRepository = communityRepository;
        }

        public async Task<Community> GetByCommunityId(int communityId)
        {
            return await _communityRepository.GetByCommunityId(communityId);
        }
        public async Task<IEnumerable<Community>> GetByCommunityIds(List<int> communityIds)
        {
            return await _communityRepository.GetByCommunityIds(communityIds);
        }

        public async Task<IEnumerable<Community>> GetByPartnerIdAndByUserId(int partnerId, int userId)
        {
            return await _communityRepository.GetByPartnerIdAndByUserId(partnerId, userId);
        }


        public async Task<IEnumerable<Community>> GetCommunitiesByPartnerId(int partnerId)
        {
            return await _communityRepository.GetCommunitiesByPartnerId(partnerId);
        }

        public async Task<IEnumerable<Community>> GetBySiteIds(List<int> siteIds)
        {
            return await _communityRepository.GetBySiteIds(siteIds);
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

        public async Task<IEnumerable<Community>> GetGridByPartnerIdAndByUserId(int partnerId, int userId, string searchTerm, int commType = 0)
        {
            var communities =(await _communityRepository.GetByPartnerIdAndByUserId(partnerId, userId)).ToList();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.Trim();
                communities = communities.Where(x => x.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();                                
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
            
            return communities;
        }

        public async Task<IEnumerable<Community>> GetActiveCommunitiesByCommunityIds(List<int> communityIds)
        {
            return await _communityRepository.GetActiveCommunitiesByCommunityIds(communityIds);
        }
    }
}
