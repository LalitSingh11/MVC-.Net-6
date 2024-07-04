using BHI.SalesArchitect.Core.Extensions;
using BHI.SalesArchitect.Model.DB;
using BHI.SalesArchitect.Service;
using BHI.SalesArchitect.WebAdmin.Models.Communities;
using BHI.SalesArchitect.WebAdmin.Models.PartnerConfiguartion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcJqGrid;
using Newtonsoft.Json;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    [Authorize]
    public class PartnerConfigurationController : BaseController
    {
        private IProspectConfigurationService _prospectConfigurationService;
        private IConfigurationService _configurationService;
        private ISessionService _sessionService;
        private ICommunityService _communityService;
        private ICustomizedContentService _customizedContentService;
        public PartnerConfigurationController(IProspectConfigurationService prospectConfigurationService,
            IConfigurationService configurationService,
            ISessionService sessionService,
            ICommunityService communityService,
            ICustomizedContentService customizedContentService)
        {
            _prospectConfigurationService = prospectConfigurationService;
            _configurationService = configurationService;
            _sessionService = sessionService;
            _communityService = communityService;
            _customizedContentService = customizedContentService;
            
        }
        public async Task<IActionResult> Index()
        {
            await InitViewBag();
            return View();
        }

        #region Get Methods
        [HttpGet]
        public async Task<IActionResult> GetProspectConfiguration()
        {
            var prospectConfigs = await _prospectConfigurationService.GetByPartnerId(_sessionService.PartnerID ?? PartnerId);
            return Ok(prospectConfigs);
        }

        [HttpGet]
        public async Task<IActionResult> GetPopTitlesConfiguration()
        {
            var popTitlesConfigs = await _configurationService.GetIspConfigurationsByPartnerId(_sessionService.PartnerID ?? PartnerId);
            return Ok(popTitlesConfigs);
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomizedContent()
        {
            int partnerId = _sessionService.PartnerID ?? PartnerId;
            var customizedContent = await _customizedContentService.GetByPartnerId(partnerId);
            var holdALot = (await _prospectConfigurationService.GetByPartnerId(partnerId))?.HoldAlot ?? false;

            return Ok(new { customizedContent, holdALot });
        }
        #endregion

        #region Post Methods
        [HttpPost]
        public async Task<IActionResult> SaveProspectConfiguration([FromBody] ProspectConfiguration prospectConfiguration)
        {
            var res = await _prospectConfigurationService.SaveProspectConfiguration(_sessionService.PartnerID ?? PartnerId, UserId, prospectConfiguration);
            _sessionService.IsIsp = prospectConfiguration.IsIsp;
            return Ok(new { Success = res });
        }

        [HttpPost]
        public async Task<IActionResult> SaveIspPartnerConfiguration([FromBody] ProspectConfiguration prospectConfiguration)
        {
            var res = await _prospectConfigurationService.SaveIspPartnerConfiguration(_sessionService.PartnerID ?? PartnerId, UserId, prospectConfiguration);
            return Ok(new { Success = res });
        }

        [HttpPost]
        public async Task<IActionResult> SaveHoldALotConfiguration([FromBody] ProspectConfiguration prospectConfiguration)
        {
            var res = await _prospectConfigurationService.SaveHoldALotConfiguration(_sessionService.PartnerID ?? PartnerId, UserId, prospectConfiguration);
            return Ok(new { Success = res });
        }

        [HttpPost]
        public async Task<IActionResult> SaveDreamweaverConfiguration([FromBody] ProspectConfiguration prospectConfiguration)
        {
            var res = await _prospectConfigurationService.SaveDreamweaverConfiguration(_sessionService.PartnerID ?? PartnerId, UserId, prospectConfiguration);
            return Ok(new { Success = res });
        }

        [HttpPost]
        public async Task<IActionResult> SavePopupTitlesConfiguration([FromBody] PopupTitleConfigurations popupTilesConfigurations)
        {
            string jsonString = JsonConvert.SerializeObject(popupTilesConfigurations);
            Dictionary<string, string> popupTitlesDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            var res = await _configurationService.UpdatePopupTitlesConfiguration(popupTitlesDict, _sessionService.PartnerID ?? PartnerId);
            return Ok(new { Success = res });
        }

        public async Task<IActionResult> SavePdfConfiguration([FromBody] ProspectConfiguration prospectConfiguration)
        {
            var res = await _prospectConfigurationService.SavePdfConfiguration(_sessionService.PartnerID ?? PartnerId, UserId, prospectConfiguration);
            return Ok(new { Success = res });
        }

        #endregion

        #region Grid Methods
        [HttpGet]
        public IActionResult GetCommunitiesGrid(GridSettings gridSettings, string searchTerm)
        {

            var communities = _communityService.GetGridCommunitiesList(_sessionService.PartnerID ?? PartnerId, searchTerm);
            if (communities != null && communities.Any())
            {
                var jsonData = new
                {
                    total = (communities.Count() % gridSettings.PageSize == 0) ? communities.Count() / gridSettings.PageSize : communities.Count() / gridSettings.PageSize + 1,
                    page = gridSettings.PageIndex,
                    records = communities.Count(),
                    rows = (
                        from c in communities
                        where c.Bdxid !=0
                        select new CommunityGridModel()
                        {
                            id = c.Id,
                            cell = new Cell()
                            {
                                ID = c.Id,
                                DWStatus = c.Dwstatus.ToString(),
                                Name = c.Name,
                                Brand = c.Brand, //builderBrands.First(p => communityBuilderBrands.Any(q => q.BuilderBrandID == p.ID && q.CommunityID == c.ID)).Name,
                                Market = c.MarketName,
                            }
                        }).ToList().OrderByDynamic(!string.IsNullOrEmpty(gridSettings.SortColumn) ? gridSettings.SortColumn : "cell.Name", gridSettings.SortOrder == "desc").Select(y => new
                        {
                            y.id,
                            cell = new[]
                            {
                                y.cell.ID.ToString(),
                                y.cell.DWStatus.ToString(),
                                y.cell.Name,
                                y.cell.Brand,
                                y.cell.Market,
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
                    records = communities.Count()
                };
                return Json(jsonData);
            }
        }
        #endregion

        #region Private Methods
        private async Task InitViewBag()
        {
            var partnerConfig = await _prospectConfigurationService.GetByPartnerId(_sessionService.PartnerID ?? PartnerId);
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
