using BHI.SalesArchitect.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcJqGrid;
using BHI.SalesArchitect.Model.DB;
using BHI.SalesArchitect.Core.Constants;
using BHI.SalesArchitect.Service.Implementations;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    [Authorize]
    public class UserManagementController : BaseController
    {
        private ISessionService _sessionService;
        private IUserService _userService;
        private IUserRoleService _userRoleService;
        private IRoleService _roleService;
        private ICommunityService _communityService;
        private ICommunityUserService _communityUserService;

        public UserManagementController(ISessionService sessionService,
            IUserService userService,
            IUserRoleService userRoleService,
            IRoleService roleService,
            ICommunityService communityService,
            ICommunityUserService communityUserService)
        {
            _sessionService = sessionService;
            _userService = userService;
            _userRoleService = userRoleService;
            _roleService = roleService;
            _communityService = communityService;
            _communityUserService = communityUserService;
        }

        public IActionResult Index()
        {
            ViewData["PartnerName"] = _sessionService.PartnerName ?? PartnerName;
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }

        #region Get Methods
        #endregion

        #region Grid Methods
        [HttpGet]
        public async Task<IActionResult> GetUsers(GridSettings gridSettings)
        {
            var partnerId = _sessionService.PartnerID ?? PartnerId;
            var userId = _sessionService.UserID ?? UserId;
            List<User> users = new();
            if (User.IsInRole(Roles.BHIADMIN) || User.IsInRole(Roles.PARTNERSUPERADMIN))
            {
                users = (await _userService.GetByPartnerIdExcludingRoles(partnerId, new List<int>() { _roleService.BHIAdmin.Id, _roleService.PartnerSuperAdmin.Id })).ToList();
            }
            else if (User.IsInRole(Roles.PARTNERREADONLY))
            {
                var user = await _userService.GetById(userId);
                users.Add(user);
            }
            else
            {
                users = (await _userService.GetByPartnerIDAndCommunityUser(partnerId, userId, new List<int>() { _roleService.BHIAdmin.Id, _roleService.PartnerSuperAdmin.Id }, 2)).ToList();
                if (users.Count == 0)
                {
                    var user = await _userService.GetById(userId);
                    users.Add(user);
                }
            }
            List<CommunityUser> communityUsers = new();
            List<UserRole> userRoles = new();
            if (users != null && users.Count > 0)
            {
                communityUsers = ( await _communityUserService.GetByUserIds(users.Select(p => p.Id).ToList())).ToList();
                userRoles = _userRoleService.GetByUserIds(users.Select(p => p.Id).ToList()).ToList();
            }

            if (users.Any())
            {
                var jsonData = new
                {
                    total = (users.Count % gridSettings.PageSize == 0) ? users.Count / gridSettings.PageSize : users.Count / gridSettings.PageSize + 1,
                    page = gridSettings.PageIndex,
                    records = users.Count,
                    rows = (
                           from u in users
                           select new
                           {
                               id = u.Id,
                               cell = new[]
                               {
                                    u.Id.ToString(),
                                    u.UserName,
                                    u.FirstName,
                                    u.LastName,
                                    u.PhoneNumber,
                                    u.Email,
                                    u.ActivityStateId == 1 ? "Active" : "Inactive",
                                    u.PartnerId.ToString(),
                                    String.Join("",userRoles.Where(ur => ur.UserId == u.Id).Select(ur => ur.RoleId)),
                                    String.Join(",", communityUsers.Where(p => p.UserId == u.Id).Select(p => p.CommunityId)),

                               }
                           }).ToArray().Skip((gridSettings.PageIndex - 1) * gridSettings.PageSize).Take(gridSettings.PageSize)
                };
                return Json(jsonData);
            }
            else
            {
                var jsonData = new
                {
                    total = 1,
                    page = 1,
                    records = users.Count
                };
                return Json(jsonData);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCommunities(GridSettings gridSettings)
        {
            var partnerId = _sessionService.PartnerID ?? PartnerId;

            IEnumerable<Community> communities = new List<Community>();
            if (User.IsInRole(Roles.BHIADMIN) || User.IsInRole(Roles.PARTNERSUPERADMIN))
                communities = await _communityService.GetCommunitiesByPartnerId(partnerId);
            else
            {
                var userId = _sessionService.UserID ?? UserId;
                communities = await _communityService.GetByPartnerIdAndByUserId(partnerId, userId);
            }

            var jsonData = new
            {
                total = communities.Count() / gridSettings.PageSize + 1,
                page = gridSettings.PageIndex,
                records = communities.Count(),
                rows = (
                     from c in communities
                     select new
                     {
                         id = c.Id,
                         cell = new[]
                     {
                         c.Id.ToString(),
                         c.Name
                     }
                     }).ToArray()
            };
            return Json(jsonData);
        }
        #endregion
    }
}
