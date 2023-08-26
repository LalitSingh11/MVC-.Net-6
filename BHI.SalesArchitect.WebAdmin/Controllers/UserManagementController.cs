using BHI.SalesArchitect.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BHI.SalesArchitect.Core.Extensions;
using MvcJqGrid;
using BHI.SalesArchitect.Model.DB;

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

        public UserManagementController(ISessionService sessionService,
            IUserService userService,
            IUserRoleService userRoleService,
            IRoleService roleService,
            ICommunityService communityService)
        {
            _sessionService = sessionService;
            _userService = userService;
            _userRoleService = userRoleService;
            _roleService = roleService;
            _communityService = communityService;
        }

        public IActionResult Index()
        {
            ViewData["PartnerName"] = _sessionService.PartnerName ?? PartnerName;
            return View();
        }
        #region GET Methods
        [HttpGet]
        public IActionResult GetUsers(GridSettings gridSettings)
        {
            var sortOrderDesc = gridSettings.SortOrder == "desc";
            var users = _userService.GetSuperUsers();
            var userRoles = _userRoleService.GetByUserIds(users.Select(p => p.Id).ToList()).ToList();
            users = users.OrderBy(gridSettings.SortColumn == string.Empty ? "UserName" : gridSettings.SortColumn, sortOrderDesc).ToList();
            var currentUserId = users.FirstOrDefault(x => x.UserName != null && x.UserName.ToLower().Equals(User.Identity.Name.ToLower()))?.Id;
            var jsonData = new
            {
                total = users.Count / gridSettings.PageSize + 1,
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
                                    "Active",
                                    userRoles.Any(ur => ur.UserId == u.Id && ur.RoleId == _roleService.PartnerSuperAdmin.Id) ? "true" : "false"
                               }
                           }).ToArray(),
                currentUserId
            };
            return Json(jsonData);
            /*var partnerId = _sessionService.PartnerID;
            var userId = _sessionService.UserID;
            var sortOrderDesc = gridSettings.SortOrder == "desc";
            List<User> users = new List<User>();
            //IEnumerable<User> users;
            if (User.IsInRole("BHIADMIN") || User.IsInRole("PARTNERSUPERADMIN"))
            {
                users = _userRepository.GetByPartnerIDNotRoles(partnerId, new List<int>() { _roleRepository.BHIAdmin.ID, _roleRepository.PartnerSuperAdmin.ID }).ToList();
            }

            else if (User.IsInRole("PARTNERREADONLY"))
            {
                var user = _userRepository.GetByID(userId);
                users.Add(user);
            }
            else
            {
                users = _userRepository.GetByPartnerIDAndCommunityUser(partnerId, userId, new List<int>() { _roleRepository.BHIAdmin.ID, _roleRepository.PartnerSuperAdmin.ID }, 2).ToList();
                if (users.Count == 0)
                {
                    var user = _userRepository.GetByID(userId);
                    users.Add(user);
                }
            }
            foreach (var newval in users)
            {
                newval.ActivityStateName = newval.ActivityState.Name;
            }
            users = users.OrderBy(gridSettings.SortColumn == string.Empty ? "UserName" : gridSettings.SortColumn, sortOrderDesc).ToList();
            //Can be optimized further
            var communityUsers = new List<CommunityUser>();
            var userRoles = new List<UserRole>();
            if (users != null && users.Count() > 0)
            {
                communityUsers = _communityUserRepository.GetByUserIDs(users.Select(p => p.ID).ToList(), false).ToList();
                userRoles = _userRoleRepository.GetByUserIDs(users.Select(p => p.ID).ToList(), false).ToList();
            }

            var jsonData = new
            {
                total = users.Count() / gridSettings.PageSize + 1,
                page = gridSettings.PageIndex,
                records = users.Count(),
                rows = (
                    from u in users
                    select new
                    {
                        id = u.ID,
                        cell = new[]
                    {
                        u.ID.ToString(),
                        u.UserName,
                        u.FirstName,
                        u.LastName,
                        u.PhoneNumber,
                        u.Email,
                        String.Join(",", communityUsers.Where(p => p.UserID == u.ID).Select(p => p.CommunityID)),
                         u.Roles.FirstOrDefault().ID.ToString(),
                         u.ActivityStateName,
                         u.ActivityState.ID==1?"true":"false"
                    }
                    }).ToArray()
            };
            return Json(jsonData);*/
        }
        [HttpGet]
        public IActionResult GetCommunities(GridSettings gridSettings)
        {
            var partnerId = _sessionService.PartnerID ?? PartnerId;
            int a;
            //List<Community> communities;
            if (User.IsInRole("BHIADMIN11") || User.IsInRole("PARTNERSUPERADMIN"))
                 a = 10;
              var communities = _communityService.GetGridCommunitiesList(partnerId, "").ToList().Take(10);
            /*else
            {
                var userId = _sessionService.UserID ?? UserId;
                //communities = _communityService.GetByPartnerIDAndByUser(partnerId, userId, false).ToList();
            }*/
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
