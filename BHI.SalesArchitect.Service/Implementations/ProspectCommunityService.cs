using BHI.SalesArchitect.Infrastructure.Repositories;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class ProspectCommunityService : IProspectCommunityService
    {
        private IProspectCommunityRepository _prospectCommunityRepository;
        public ProspectCommunityService(IProspectCommunityRepository prospectCommunityRepository)
        {
            _prospectCommunityRepository = prospectCommunityRepository;
        }
        public async Task<bool> DeleteByUserId(int userId)
        {
            return await _prospectCommunityRepository.DeleteByUserId(userId);
        }
    }
}
