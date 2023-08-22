using BHI.SalesArchitect.Service;
using BHI.SalesArchitect.WebAdmin.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Diagnostics;
using BHI.SalesArchitect.WebAdmin.Models.Account;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    public class AccountController : BaseController
    {
        private IUserService _userService;
        private ISessionService _sessionService;
        private IAuthService _authService;
        private IRoleService _roleService;
        private IPartnerService _partnerService;
        public AccountController(IUserService userService,
            ISessionService session,
            IAuthService authService,
            IRoleService roleService,
            IPartnerService partnerService)
        {
            _userService = userService;
            _sessionService = session;
            _authService = authService;
            _roleService = roleService;
            _partnerService = partnerService;
        }

        public IActionResult Index(string ReturnUrl = "")
        {
            return View(new LoginModel ());
        }
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid) {
                var (isAuthenticated, user) = await _authService.Authenticate(model.UserName, model.Password);
                if (isAuthenticated)
                {
                    var partner = _partnerService.GetById((int)user.PartnerId);
                    var role = _roleService.GetByUserId(user.Id);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.Role, role.Code),
                        new Claim("UserId", user.Id.ToString()),
                        new Claim("PartnerId",user.PartnerId.ToString()),
                        new Claim("PartnerName", partner.Name),
                        new Claim("PartnerDataKey", partner.DataKey)
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    User.AddIdentity(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, 
                                                    principal,
                                                    properties: new AuthenticationProperties
                                                    {
                                                        IsPersistent = true,
                                                        ExpiresUtc = DateTime.UtcNow.AddHours(24)
                                                    });

                    UpdateSession();
                    return RedirectToAction("Index", "Communities");
                }
            }
            ModelState.AddModelError("Password", "Invalid credentials");
            return View("Index", model);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region Private Methods
        private void UpdateSession()
        {
            _sessionService.UserID = UserId;
            _sessionService.PartnerID = PartnerId;
            _sessionService.PartnerName = PartnerName;
            _sessionService.PartnerDataKey = PartnerDataKey;
        }
        #endregion
    }
}
