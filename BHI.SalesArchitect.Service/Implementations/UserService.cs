using BHI.SalesArchitect.Core.Helpers;
using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IActivityStateRepository _activityStateRepository;
        public UserService(IUserRepository userRepository,
            IActivityStateRepository activityStateRepository)
        {
            _userRepository = userRepository;
            _activityStateRepository = activityStateRepository;
        }

        public Task<bool> AddUser(User user)
        {
            user.ActivityStateId = _activityStateRepository.ActiveState.Id;
            return _userRepository.AddUser(user);
        }

        public async Task<bool> DeleteUser(int id)
        {
            var user = await GetById(id);
            if (user != null)
            {
                return await _userRepository.DeleteUser(user);
            }
            return false;
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
            dbUser.Password = String.IsNullOrWhiteSpace(user.Password) ? dbUser.Password : EncryptionHelper.GetSHA1(user.Password);
            dbUser.PartnerId = user.PartnerId;
            return await _userRepository.UpdateUser(dbUser);             
        }        
    }
}
