using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CommunityUserService : ICommunityUserService
    {
        private readonly ICommunityUserRepository _communityUserRepository;
        private readonly IActivityStateRepository _activityStateRepository;
        public CommunityUserService(ICommunityUserRepository communityUserRepository,
            IActivityStateRepository activityStateRepository)
        {
            _communityUserRepository = communityUserRepository;
            _activityStateRepository = activityStateRepository;
        }

        public async Task<bool> AddByUserId(int userId, List<int> commIds)
        {
            List<CommunityUser> commUsers = new();
            foreach (var commId in commIds)
            {
                var commUser = new CommunityUser
                {
                    UserId = userId,
                    CommunityId = commId,
                    ActivityStateId = _activityStateRepository.ActiveState.Id
                };
                commUsers.Add(commUser);
            }
            return await _communityUserRepository.AddCommunityUser(commUsers);
        }

        public async Task<bool> DeleteByUserId(int userId)
        {
            return await _communityUserRepository.DeleteByUserId(userId);
        }

        public async Task<IEnumerable<CommunityUser>> GetByCommunityIDs(List<int> communityIDs)
        {
           return await _communityUserRepository.GetByCommunityIds(communityIDs);
        }

        public async Task<IEnumerable<CommunityUser>> GetByUserIds(List<int> userIds)
        {
            return await _communityUserRepository.GetByUserIDs(userIds);
        }

        public async Task<bool> UpdateByUserId(int userId, List<int> commIds)
        {
            await _communityUserRepository.DeleteByUserId(userId);
            List<CommunityUser> commUsers = new();
            foreach(var commId in commIds)
            {
                var commUser = new CommunityUser
                {
                    UserId = userId,
                    CommunityId = commId,
                    ActivityStateId = _activityStateRepository.ActiveState.Id
                };
                commUsers.Add(commUser);
            }
            return await _communityUserRepository.AddCommunityUser(commUsers);
        }
    }
}
