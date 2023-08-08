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

        public PartnerAdministrationController(IPartnerService partnerService,
            IBuilderBrandService builderBrandService,
            IUserRoleService userRoleService,
            IUserService userService,
            IRoleService roleService)
        {
            _partnerService = partnerService;
            _builderBrandService = builderBrandService;
            _userRoleService = userRoleService;
            _userService = userService;
            _roleService = roleService;
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
                    }).ToArray()
            };
            return Json(jsonData);
        }
        [HttpGet]
        public IActionResult GetUsers(GridSettings gridSettings)
        {
            var sortOrderDesc = gridSettings.SortOrder == "desc";
            var users = _userService.GetSuperUsers().ToList();
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
                                    String.Join(",", userRoles.Any(p => p.UserId == u.Id && p.UserId == _roleService.PartnerSuperAdmin.Id) ? "true":"false")
                               }
                           }).ToArray(),
                /*userdata = new
                {
                    selId = currentUserId
                }*/
            };
            return Json(jsonData);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserData(int userId)
        {
            var user = await _userService.GetById(userId);
            return Ok(user);
        }
    }
}

