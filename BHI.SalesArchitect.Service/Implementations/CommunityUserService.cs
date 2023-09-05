using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CommunityUserService : ICommunityUserService
    {
        private readonly ICommunityUserRepository _communityUserRepository;
        public CommunityUserService(ICommunityUserRepository communityUserRepository)
        {
            _communityUserRepository = communityUserRepository;
        }
        public async Task<IEnumerable<CommunityUser>> GetByCommunityIDs(List<int> communityIDs)
        {
           return await _communityUserRepository.GetByCommunityIds(communityIDs);
        }

        public async Task<IEnumerable<CommunityUser>> GetByUserIds(List<int> userIds)
        {
            return await _communityUserRepository.GetByUserIDs(userIds);
        }
    }
}
