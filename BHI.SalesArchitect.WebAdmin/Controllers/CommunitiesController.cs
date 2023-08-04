using BHI.SalesArchitect.Core.Enumerations;
using BHI.SalesArchitect.Service;
using BHI.SalesArchitect.WebAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcJqGrid;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    [Authorize]
    public class CommunitiesController : BaseController
    {
        private ICommunityService _communityService;
        private ICommunityUserService _communityUserService;
        private IUserService _userService;
        private ICommunitySiteService _communitySiteService;
        private ICommunitySiteGeoJsonService _communitySiteGeoJsonService;
        private ISiteService _siteService;
        private IMasterPlanService _masterPlanService;
        private ISessionService _sessionService;
        private IProspectConfigurationService _prospectConfigurationService;
        public CommunitiesController(ICommunityService communityService,
            ICommunityUserService communityUserService,
            IUserService userService,
            ICommunitySiteService communitySiteService,
            ICommunitySiteGeoJsonService communitySiteGeoJsonService,
            ISiteService siteService,
            IMasterPlanService masterPlanService,
            ISessionService sessionService,
            IProspectConfigurationService prospectConfigurationService
            ) 
        {
            _communityService = communityService;
            _communityUserService = communityUserService;
            _userService = userService;
            _communitySiteService = communitySiteService;
            _communitySiteGeoJsonService = communitySiteGeoJsonService;
            _siteService = siteService;
            _masterPlanService = masterPlanService;
            _sessionService = sessionService;
            _prospectConfigurationService = prospectConfigurationService;
        }
        
        public IActionResult Index()
        {
            InitViewBag();
            ViewData["PartnerName"] = PartnerName;
            return View();
        }

        [HttpGet]
        public IActionResult GetCommunitiesGrid(GridSettings gridSettings, string searchTerm, int commStatusType = 0, int commType = 0)
        {
            var communities = _communityService.GetGridCommunitiesList(PartnerId, searchTerm, commStatusType, commType);            
            var communityAdmins = _userService.GetCommunityAdminsByCommunityIDs(communities.Select(p => p.Id).ToList());
            var communityUsers = _communityUserService.GetByCommunityIDs(communities.Select(p => p.Id).ToList()).ToList();
            var communitySites = _communitySiteService.GetActiveCommunitySites(communities.Select(p => p.Id).ToList()).ToList();
            var communityMasterSites = _communityService.GetByCommunityIDs(communities.Select(p => p.Id).ToList()).ToList();
            var communitySiteGeoJson = _communitySiteGeoJsonService.GetByCommunityIds(communities.Select(p => p.Id).ToList()).ToList();
            var partnerConfig = _prospectConfigurationService.GetByPartnerId(PartnerId);
            var jsonData = new
            {
                total = (communities.Count() % gridSettings.PageSize == 0) ? communities.Count() / gridSettings.PageSize : communities.Count() / gridSettings.PageSize + 1,
                page = gridSettings.PageIndex,
                records = communities.Count(),
                rows = (
                        from c in communities
                        select new CommunityGridModel()
                        {
                            id = c.Id,
                            cell = new Cell()
                            {
                                ID = c.Id,
                                DWStatus = c.Dwstatus == 1 ? "Active" : c.Dwstatus == 3 ? "Pending" : "Inactive",
                                Name = c.Bdxid == 0 ? "" : c.Name,
                                Brand = c.Brand, //builderBrands.First(p => communityBuilderBrands.Any(q => q.BuilderBrandID == p.ID && q.CommunityID == c.ID)).Name,
                                Market = c.MarketName,
                                ISPName = c.Ispname,
                                LotsCount = c.LotCount ?? 0,
                                ProspectCount = c.ProspectCount ?? 0,
                                Admins = communityAdmins.Where(p => communityUsers.Any(q => q.UserId == p.Id && q.CommunityId == c.Id)).Select(p => p.FirstName + " " + p.LastName).FirstOrDefault(),
                                ActivityState = c.ActivityStateName,
                                //Address = string.Format("{0}, {1}", c.City, c.State),
                                Sites = communitySites.Any(p => p.CommunityId == c.Id) ? communitySites.First(p => p.CommunityId == c.Id).SiteId.ToString() : communitySiteGeoJson.Any(csj => csj.CommunityId == c.Id && csj.GeoJsontype == 1) ? communitySiteGeoJson.First(csj => csj.CommunityId == c.Id && csj.GeoJsontype == 1).SiteId.ToString() : "-1",
                                MasterSites = communityMasterSites.Any(cm => cm.Id == c.Id) ? communityMasterSites.First(cm => cm.Id == c.Id).MasterPlanId.ToString() : "-1",
                                Locked = c.Locked.ToString(),
                                NewIsp = c.NewIsp.ToString(),
                                ISPVersion = GetISPVersion(communitySiteGeoJson.Any(csj => csj.CommunityId == c.Id && csj.GeoJsontype == 1), c.NewIsp, communitySites.Any(p => p.CommunityId == c.Id) ? communitySites.First(p => p.CommunityId == c.Id).SiteId : -1, partnerConfig.IspPartnerType),
                                BDXId = c.Bdxid,
                                HasGeoJson = partnerConfig.IspPartnerType != (int)CommonEnumerations.IspPartnerType.SVG && (communitySiteGeoJson.Any(csj => csj.CommunityId == c.Id && csj.GeoJsontype == 1)),
                                HasSVG = partnerConfig.IspPartnerType != (int)CommonEnumerations.IspPartnerType.PaidGeoSpatial && communitySites.Any(p => p.CommunityId == c.Id),
                                IsGeoSVG = GeoSVGCheck(communitySites.Any(p => p.CommunityId == c.Id) ? communitySites.First(p => p.CommunityId == c.Id).SiteId : -1),
                                IsMasterGeoSVG = MasterGeoSVGCheck((communityMasterSites.Any(cm => cm.Id == c.Id) ? communityMasterSites.First(cm => cm.Id == c.Id).MasterPlanId : -1) ?? -1),
                                DateDeleted = c.DateDeleted != null && c.DateDeleted != DateTime.MinValue ? c.DateDeleted.Value.ToShortDateString() : "",
                                DeletedBy = c.DeletedBy ?? "",
                                Status = c.Status,
                                Type = c.Bdxid == 0 ? "Standalone" : "BDXLive Connected"
                            }
                        }).ToList().Select(y => new
                        {
                            y.id,
                            cell = new[]
                            {
                                y.cell.ID.ToString(),
                                y.cell.Brand,
                                y.cell.Market,
                                y.cell.ISPName,
                                y.cell.Name,
                                y.cell.LotsCount.ToString(),
                                y.cell.ProspectCount.ToString(),
                                y.cell.Admins,
                                y.cell.ISPVersion,
                                y.cell.ActivityState,
                                /*y.cell.Address,
                                y.cell.Sites,
                                y.cell.MasterSites,
                                y.cell.Locked,
                                y.cell.NewIsp,*/
                                y.cell.ID.ToString(),
                                y.cell.Sites.ToString(),
                                y.cell.BDXId.ToString(),
                               /* y.cell.HasGeoJson.ToString(),
                                y.cell.HasSVG.ToString(),
                                y.cell.IsGeoSVG.ToString(),
                                y.cell.IsMasterGeoSVG.ToString(),*/
                                y.cell.Type.ToString(),
                                y.cell.Status.ToString(),
                                y.cell.DWStatus.ToString(),
                                y.cell.DateDeleted.ToString(),
                                y.cell.DeletedBy.ToString()
                            }
                        }).ToArray()/*.Skip((gridSettings.PageIndex - 1) * gridSettings.PageSize).Take(gridSettings.PageSize)*/
            };
            return new JsonResult(jsonData);
        
        }

        #region Private Methods
        private string GetISPVersion(bool hasGeoJson, bool isNewISP, int siteID, int ispPartnerType)
        {
            var hasGeoSVG = false;
            if (siteID != -1)
            {
                var site = _siteService.GetByIdWithoutSvg(siteID);
                hasGeoSVG = site.IsGeoSvg;
            }
            switch (ispPartnerType)
            {
                case 1:
                    return isNewISP ? "2.0" : "1.0";
                case 2:
                    return hasGeoJson ? "Geospatial" : "-";
                case 3:
                    return hasGeoJson || hasGeoSVG ? "Geospatial" : "-";
                case 4:
                    return (hasGeoJson || hasGeoSVG ? (isNewISP ? "Geospatial, 2.0" : "Geospatial ,1.0") : (isNewISP ? "2.0" : "1.0"));
                default:
                    return "-";
            }
        }
        private bool GeoSVGCheck(int siteID)
        {
            if (siteID != -1)
            {
                var site = _siteService.GetByIdWithoutSvg(siteID);
                return site.IsGeoSvg;
            }
            return false;
        }

        private bool MasterGeoSVGCheck(int masterPlanId)
        {
            if (masterPlanId != -1)
            {
                var masterPlan = _masterPlanService.GetByIdWithoutSvg(masterPlanId);
                return masterPlan.IsMasterGeoSvg;
            }
            return false;
        }
       private void InitViewBag()
       {
            var partnerConfig = _prospectConfigurationService.GetByPartnerId(PartnerId);
            ViewBag.showDreamweaver = partnerConfig != null ? partnerConfig.IsDreamweaver : false;
            ViewBag.IspPartnerType = partnerConfig?.IspPartnerType ?? 1;
            ViewBag.PreviewPlugin = partnerConfig?.PreviewIspplugin ?? false;
            ViewBag.HoldALotEnabled = partnerConfig?.HoldAlot ?? false;
            ViewBag.IsDreamweaver = partnerConfig?.IsDreamweaver ?? false;
            ViewBag.DisplayLotListEnabled = partnerConfig?.DisplayLotList ?? false;
            ViewBag.AddModelHomesBanner = partnerConfig?.AddModelHomesBanner ?? false;
            ViewBag.ReplaceKeyIcon = partnerConfig?.ReplaceKeyIcon ?? false;
            ViewBag.DisplayAvailablePlans = partnerConfig?.ShowAllPlans ?? true;
            ViewBag.DisplayAvailableSpecs = partnerConfig?.ShowAllSpecs ?? true;
            ViewBag.NHTBuilderNumber = partnerConfig?.NhtbuilderNumber ?? String.Empty;
            ViewBag.IsISPOnly = partnerConfig?.IsIsp ?? false;
        }
        #endregion

    }
}

