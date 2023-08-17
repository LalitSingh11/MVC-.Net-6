using BHI.SalesArchitect.Core.Helpers;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class AuthService : IAuthService
    {
        readonly IUserService _userService;
        readonly ISessionService _sessionService;
        public AuthService(IUserService userService,
            ISessionService sessionService)
        {
            _userService = userService;
            _sessionService = sessionService;
        }

        public async Task<(bool, User)> Authenticate(string userName, string password)
        {
            var userDetails = await _userService.GetByUsername(userName);
            if (userDetails != null && CheckPassword(password, userDetails.Password))
                return (true, userDetails);
            return (false, null);
        }

        private static bool CheckPassword(string password, string dbPassword)
        {
            var encodedPass = EncryptionHelper.GetSHA1(password);
            return encodedPass == dbPassword;
        }
    }
}
