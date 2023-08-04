using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _userRepository.GetByUserName(username);
        }

        public IEnumerable<User> GetCommunityAdminsByCommunityIDs(List<int> communityIDs)
        {
            return _userRepository.GetCommunityAdminsByCommunityID(communityIDs).ToList();
        }

    }
}
