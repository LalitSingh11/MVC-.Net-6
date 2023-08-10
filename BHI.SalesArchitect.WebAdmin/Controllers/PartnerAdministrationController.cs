using BHI.SalesArchitect.Model.DB;
using BHI.SalesArchitect.Service;
using BHI.SalesArchitect.WebAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using MvcJqGrid;
using static BHI.SalesArchitect.Core.Enumerations.CommonEnumerations;
using BHI.SalesArchitect.Core.Extensions;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    public class PartnerAdministrationController : BaseController
    {
        private IPartnerService _partnerService;
        private IBuilderBrandService _builderBrandService;
        private IUserRoleService _userRoleService;
        private IUserService _userService;
        private IRoleService _roleService;
        private ISessionService _sessionService;
        private IProspectConfigurationService _prospectConfigurationService;

        public PartnerAdministrationController(IPartnerService partnerService,
            IBuilderBrandService builderBrandService,
            IUserRoleService userRoleService,
            IUserService userService,
            IRoleService roleService,
            ISessionService sessionService,
            IProspectConfigurationService prospectConfigurationService)
        {
            _partnerService = partnerService;
            _builderBrandService = builderBrandService;
            _userRoleService = userRoleService;
            _userService = userService;
            _roleService = roleService;
            _sessionService = sessionService;
            _prospectConfigurationService = prospectConfigurationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetPartners(GridSettings gridSettings, int partnerStatusType = 0)
        {
            var partners = _partnerService.GetAllPartners(new int[] { (int)PartnerType.SalesArchitect }, partnerStatusType);

            var sites = new List<PartnerGridModel>();
            foreach (Partner instance in partners)
            {
                List<string> brands = _builderBrandService.GetByPartnerId(instance.Id)?.Select(x => x.Name)?.Distinct()?.ToList();
                var s = new PartnerGridModel
                {
                    Id = instance.Id,
                    Name = instance.Name + " (" + instance.Bdxid + ")",
                    Bdxid = instance.Bdxid,
                    Status = instance.Status,
                    ISPName = instance.Ispname,
                    DataKey = instance.DataKey,
                    PartnerBrands = brands == null || !brands.Any() ? null : string.Join(", ", brands),
                };
                sites.Add(s);
            }
            var currentPartnerId = partners.FirstOrDefault(x => x.Id == (_sessionService.PartnerID ?? PartnerId))?.Id;
            var sortOrderDesc = gridSettings.SortOrder == "desc";
            sites = sites.OrderBy(x => x.PartnerBrands == null).ThenBy(x => x.PartnerBrands).ToList();
            var jsonData = new
            {
                total = sites.Count / gridSettings.PageSize + 1,
                page = gridSettings.PageIndex,
                records = sites.Count,
                rows = (
                    from s in sites
                    select new
                    {
                        id = s.Id,
                        cell = new[]
                        {
                        s.Id.ToString(),
                        s.ISPName,
                        s.Name,
                        s.PartnerBrands,
                        s.DataKey,
                        s.Status ? "Active" : "Inactive",
                        "<button type=\"button\" class=\"edit-partner-btn\" data-id=\""+s.Id+"\" data-bdxid=\""+s.Bdxid+"\" data-ispname=\""+s.ISPName+"\" data-status=\""+s.Status+"\"data-target=\"#editPartnerModal\" data-toggle=\"modal\">Edit</button>"
                        }
                    }).ToArray(),
                currentPartnerId
            };
            return Json(jsonData);
        }
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
                                    u.PartnerId.ToString(),
                                    userRoles.Any(ur => ur.UserId == u.Id && ur.RoleId == _roleService.PartnerSuperAdmin.Id) ? "true" : "false"
                               }
                           }).ToArray(),
                currentUserId                
            };
            return Json(jsonData);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserData(int userId)
        {
            var user = await _userService.GetById(userId);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser([FromBody]RegisterModel model, int userId)
        {
            try
            {
                var user = new User
                {
                    Id = userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    //PartnerId = model.AssociationIds.FirstOrDefault(),
                    Email = model.Email,
                    Password = model.Password,
                    PhoneNumber = model.PhoneNumber,     
                    PartnerId = int.Parse(model.AssociationIds)
            };
                await _userService.UpdateUser(user);
                var roleId = model.IsPartnerSuperAdmin ? _roleService.PartnerSuperAdmin.Id : _roleService.BHIAdmin.Id;
                await _userRoleService.UpdateUserRole(userId, roleId);                
                //If we are changing the actual user partner.
                if (UserId == userId && PartnerId != user.PartnerId)
                {
                    _sessionService.PartnerID = user.PartnerId;
                    var partner = _partnerService.GetById((int)user.PartnerId);
                    _sessionService.PartnerName = partner.Name;
                    _sessionService.PartnerDataKey = partner.DataKey;
                    _sessionService.UserID = userId;
                    //var config = _prospectConfigurationService.GetByPartnerId(user.PartnerId);
                    //_sessionService.IsIsp = (bool)(config != null && config.isisp is not null);
                }
                return Json(new { Success = "true" });
            }
            catch (Exception ex)
            {
                return Json(new { Success = "false", Error = ex.Message });
            }
        }
    }
}

