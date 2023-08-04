using BHI.SalesArchitect.Model.DB;
using Microsoft.AspNetCore.Http;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class AuthService : IAuthService
    {
        IUserService _userService;
        ISessionService _sessionService;
        public AuthService(IUserService userService,
            ISessionService sessionService)
        {
            _userService = userService;
            _sessionService = sessionService;
        }

        public async Task<(bool, User)> Authenticate(string userName, string password)
        {
            var userDetails = await _userService.GetByUsernameAsync(userName);
            _sessionService.PartnerID = userDetails.PartnerId;
            if (userDetails != null && CheckPassword(password, userDetails.Password))
                return (true, userDetails);
            return (false, null);
        }

        private bool CheckPassword(string password, string dbPassword)
        {
            string pass1 = password;
            string pass2 = dbPassword;

            /*switch (PasswordFormat)
            {
                case MembershipPasswordFormat.Encrypted:
                    pass2 = SecurityUtility.Decrypt(dbPassword);
                    break;
                case MembershipPasswordFormat.Hashed:
                    pass1 = SecurityUtility.HashPassword(password);
                    break;
                default:
                    break;
            }*/
            return true;
            return !string.IsNullOrEmpty(pass2) && pass1 == pass2;
        }

    }
}
