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
        public IEnumerable<CommunityUser> GetByCommunityIDs(List<int> communityIDs)
        {
           return _communityUserRepository.GetByCommunityIDs(communityIDs);
        }
    }
}
