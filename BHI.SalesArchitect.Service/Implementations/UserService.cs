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

        public async Task<User> GetById(int id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<User> GetByUsername(string username)
        {
            return await _userRepository.GetByUserName(username);
        }

        public IEnumerable<User> GetCommunityAdminsByCommunityIDs(List<int> communityIDs)
        {
            return _userRepository.GetCommunityAdminsByCommunityID(communityIDs).ToList();
        }

        public IEnumerable<User> GetSuperUsers()
        {
            return _userRepository.GetSuperUsers().ToList();
        }
    }
}
