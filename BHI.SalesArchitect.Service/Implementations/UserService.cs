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

        public List<User> GetCommunityAdminsByCommunityIDs(List<int> communityIDs)
        {
            return _userRepository.GetCommunityAdminsByCommunityID(communityIDs).ToList();
        }

        public List<User> GetSuperUsers()
        {
            return _userRepository.GetSuperUsers().ToList();
        }

        public async Task<bool> UpdateUser(User user)
        {
            var dbUser = await GetById(user.Id);
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Email = user.Email;  
            dbUser.PhoneNumber = user.PhoneNumber;
            dbUser.UserName = user.UserName;
            dbUser.Password = user.Password;
            dbUser.PartnerId = user.PartnerId;
            var a = await _userRepository.UpdateUser(dbUser);
            return a;
        }
    }
}
