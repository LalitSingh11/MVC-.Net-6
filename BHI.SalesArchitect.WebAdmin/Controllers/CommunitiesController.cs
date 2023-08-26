using BHI.SalesArchitect.Core.Enumerations;
using BHI.SalesArchitect.Core.Extensions;
using BHI.SalesArchitect.Service;
using BHI.SalesArchitect.WebAdmin.Models.Communities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcJqGrid;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    [Authorize]
    public class CommunitiesController : BaseController
    {
        private readonly ICommunityService _communityService;
        private readonly ICommunityUserService _communityUserService;
        private readonly IUserService _userService;
        private readonly ICommunitySiteService _communitySiteService;
        private readonly ICommunitySiteGeoJsonService _communitySiteGeoJsonService;
        private readonly ISiteService _siteService;
        private readonly IMasterPlanService _masterPlanService;
        private readonly ISessionService _sessionService;
        private readonly IProspectConfigurationService _prospectConfigurationService;
        private readonly ILotService _lotService;
        private readonly IListingService _listingService;
        private readonly ILotStateService _lotStateService;
        private readonly ILotListingService _lotListingService;
        private readonly IRoleService _roleService;

        public CommunitiesController(ICommunityService communityService,
            ICommunityUserService communityUserService,
            IUserService userService,
            ICommunitySiteService communitySiteService,
            ICommunitySiteGeoJsonService communitySiteGeoJsonService,
            ISiteService siteService,
            IMasterPlanService masterPlanService,
            ISessionService sessionService,
            IProspectConfigurationService prospectConfigurationService,
            ILotService lotService,
            IListingService listingService,
            ILotStateService lotStateService,
            ILotListingService lotListingService,
            IRoleService roleService
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
            _lotService = lotService;
            _lotStateService = lotStateService;
            _listingService = listingService;
            _lotListingService = lotListingService;
            _roleService = roleService;
        }
        
        public async Task<IActionResult> Index()
        {
            await InitViewBag();
            ViewData["PartnerName"] = _sessionService.PartnerName ?? PartnerName;
            return View();
        }
        #region GRIDS

        [HttpGet]
        public async Task<IActionResult> GetCommunitiesGrid(GridSettings gridSettings, string searchTerm, int commStatusType = 0, int commType = 0)
        {
            var communities = _communityService.GetGridCommunitiesList(_sessionService.PartnerID ?? PartnerId, searchTerm, commStatusType, commType);
            _sessionService.CommunityID = communities.FirstOrDefault()?.Id ?? 1;
            var commIds = communities.Select(p => p.Id).ToList();
            var communityAdmins = _userService.GetCommunityAdminsByCommunityIDs(commIds);
            var communityUsers = _communityUserService.GetByCommunityIDs(commIds).ToList();
            var communitySites = _communitySiteService.GetActiveCommunitySites(commIds).ToList();
            var communityMasterSites = _communityService.GetByCommunityIDs(commIds).ToList();
            var communitySiteGeoJson = _communitySiteGeoJsonService.GetByCommunityIds(commIds).ToList();
            var partnerConfig = await _prospectConfigurationService.GetByPartnerId(_sessionService.PartnerID ?? PartnerId);
            var jsonData = new
            {
                total = (communities.Count() % gridSettings.PageSize == 0) ? communities.Count() / gridSettings.PageSize : communities.Count() / gridSettings.PageSize + 1,
                page = gridSettings.PageIndex,
                records = communities.Count(),
                rows = (
                        communities.Select(c =>
                        new CommunityGridModel()
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
                                Sites = communitySites.Any(p => p.CommunityId == c.Id) ? communitySites.First(p => p.CommunityId == c.Id).SiteId.ToString() : communitySiteGeoJson.Any(csj => csj.CommunityId == c.Id && csj.GeoJsontype == 1) ? communitySiteGeoJson.First(csj => csj.CommunityId == c.Id && csj.GeoJsontype == 1).SiteId.ToString() : "",
                                MasterSites = communityMasterSites.Any(cm => cm.Id == c.Id) ? communityMasterSites.First(cm => cm.Id == c.Id).MasterPlanId.ToString() : "-1",
                                Locked = c.Locked.ToString(),
                                NewIsp = c.NewIsp.ToString(),
                                ISPVersion = GetISPVersion(communitySiteGeoJson.Any(csj => csj.CommunityId == c.Id && csj.GeoJsontype == 1), c.NewIsp, communitySites.Any(p => p.CommunityId == c.Id) ? communitySites.First(p => p.CommunityId == c.Id).SiteId : -1, (partnerConfig?.IspPartnerType ?? 1)),
                                BDXId = c.Bdxid,
                                HasGeoJson = (partnerConfig?.IspPartnerType ?? 1) != (int)CommonEnumerations.IspPartnerType.SVG && (communitySiteGeoJson.Any(csj => csj.CommunityId == c.Id && csj.GeoJsontype == 1)),
                                HasSVG = (partnerConfig?.IspPartnerType ?? 1) != (int)CommonEnumerations.IspPartnerType.PaidGeoSpatial && communitySites.Any(p => p.CommunityId == c.Id),
                                IsGeoSVG = GeoSVGCheck(communitySites.Any(p => p.CommunityId == c.Id) ? communitySites.First(p => p.CommunityId == c.Id).SiteId : -1),
                                IsMasterGeoSVG = MasterGeoSVGCheck((communityMasterSites.Any(cm => cm.Id == c.Id) ? communityMasterSites.First(cm => cm.Id == c.Id).MasterPlanId : -1) ?? -1),
                                DateDeleted = c.DateDeleted != null && c.DateDeleted != DateTime.MinValue ? c.DateDeleted.Value.ToShortDateString() : "",
                                DeletedBy = c.DeletedBy ?? "",
                                Status = c.Status,
                                Type = c.Bdxid == 0 ? "Standalone" : "BDXLive Connected"
                            }
                        }).ToList().OrderByDynamic(!string.IsNullOrEmpty(gridSettings.SortColumn) ? gridSettings.SortColumn : "cell.Name", gridSettings.SortOrder == "desc").Select(y => new
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
                        }).ToArray().Skip((gridSettings.PageIndex - 1) * gridSettings.PageSize).Take(gridSettings.PageSize))
            };
            return new JsonResult(jsonData);        
        }

        [HttpGet]
        public IActionResult GetLotsByCommId(GridSettings gridSettings, int commId)
        {
            var lots  = _lotService.GetByCommId(commId);
            _sessionService.CommunityID = commId;
            var jsonData = new
            {
                total = lots.Count(),

                rows = (
                           from l in lots
                           select new
                           {
                               id = l.Id,
                               cell = new[]
                               {
                                    l.Id.ToString(),
                                    GetLotNumber(l.InternalReference)
                               }
                           }).ToArray(),
            };
            return Json(jsonData);
        }


        #endregion

        #region Get Methods
        [HttpGet]
        public async Task<IActionResult> GetLotInfo(int lotId, int commId)
        {
            _sessionService.CommunityID = commId;
            var listings = _listingService.GetByCommunityId(commId);
            var lotListings = _lotListingService.GetByLotId(lotId);
            var lotInfo = new
            {
                lotData = await _lotService.GetByID(lotId),
                lotState = _lotStateService.GetByPartnerId(_sessionService.PartnerID ?? PartnerId),
                listings = (from l in listings
                           join ll in lotListings on l.Id equals ll.ListingId
                           select new
                           {
                               l.Id,
                               ll.Price,
                               ll.ListingImagesId
                           }).ToList(),
                plans = listings.Where(x => x.Type == "P").ToList(),
                specs = listings.Where(x => x.Type == "S").ToList(),
                models = listings.Where(x => x.Type == "M").ToList(),
            };
            return Ok(lotInfo);
        }

        /*[HttpGet]
        public async Task<IActionResult> GetListingImages(int listingId, int lotid)
        {
            return Ok();
        }*/
        /*  [HttpGet]
          public IActionResult GetLotImage(int id, int maxwidth = 0, int maxheight = 0)
          {
              IActionResult result = null;
              try
              {
                  var gifType = _assetTypeRepository.GifType;
                  var jpgType = _assetTypeRepository.JpgType;

                  var lot = _lotRepository.GetByID(id);

                  if (lot != null)
                  {
                      var buffer = _imageFileService.ReadImageToByte(_pathFactory.BuildAbsolute(_directoryPath, lot.ImagePath), maxwidth, maxheight);
                      if (buffer != null)
                          result = new FileStreamResult(new MemoryStream(buffer), FileImage.GetFileType(Path.GetExtension(lot.ImagePath).ToLower().Remove(0, 1)));
                      else
                      {
                          _logService.Error("Bad Path or Something: Directory Path:" + _directoryPath + " Value:" + lot.ImagePath + " pathFactory:" + _pathFactory.BuildAbsolute(_directoryPath, lot.ImagePath));
                      }
                  }
              }
              catch (Exception e)
              {
                  _logService.Error(Request.Url.PathAndQuery, e);
              }


              return result ?? (result = new HttpNotFoundResult());
          }*/
        #endregion

        #region Post Methods
        [HttpPost]
        public async Task<IActionResult> UpdateLot([FromBody] LotListingsDataModel data)
        {
            if(ModelState.IsValid)
            {
                var result1 = await _lotService.UpdateLot(data.lot);
                var result2 = await _lotListingService.UpdateLotListings(data.lotListing, data.lot.Id);
                return Json(new { Success = result1 || result2 });
            }
            return BadRequest(new { Success = false });
        }
        #endregion

        #region Private Methods
        private static string GetLotNumber(string internalReference)
        {
            var splittedString = internalReference.Split('_');
            return (splittedString.Length > 1) ? splittedString[1] : splittedString[0];
        }
        private string GetISPVersion(bool hasGeoJson, bool isNewISP, int siteID, int ispPartnerType)
        {
            var hasGeoSVG = false;
            if (siteID != -1)
            {
                var site = _siteService.GetByIdWithoutSvg(siteID);
                hasGeoSVG = site.IsGeoSvg ?? false;
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
                return site.IsGeoSvg ?? false;
            }
            return false;
        }

        private bool MasterGeoSVGCheck(int masterPlanId)
        {
            if (masterPlanId != -1)
            {
                var masterPlan = _masterPlanService.GetByIdWithoutSvg(masterPlanId);
                return masterPlan.IsMasterGeoSvg ?? false;
            }
            return false;
        }
       private async Task InitViewBag()
       {
            var partnerConfig = await _prospectConfigurationService.GetByPartnerId(_sessionService.PartnerID ?? PartnerId);
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

