using System.Collections.Generic;
using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class SiteMapPreview
    {
        public string MapData { get; set; }
        public bool ShowTitleBar { get; set; }
        public bool ShowGrayBar { get; set; }
        public IEnumerable<MasterPlanCommunity> OtherCommunities { get; set; }
        public bool IsMasterSitePlan { get; set; }
        public IEnumerable<SiteMapLot> LotData { get; set; }
        public bool ShowLoadingBar { get; set; }
        public int PartnerID { get; set; }
        public string CommunityName { get; set; }
        public int? CommunityId { get; set; }
        public int? MasterSiteId { get; set; }
        public bool IsZipCodeRequired { get; set; }
        public bool RequestInfoModal { get; set; }
        public string BuilderBrandLogo { get; set; }
        public bool IsBuilderLogo { get; set; }
        public List<PartnerSetting> PartnerSettings { get; set; }
        public IEnumerable<SiteOverviewListing> DefaultListingData { get; set; }
        public List<CommunityConfiguration> SiteMapConfigurations { get; set; }
        public List<CommunityConfiguration> Legends { get; set; }
        public bool ShowAllPlans { get; set; }
        public Dictionary<string, string> PopupConfiguration { get; set; }
        public bool SendLotId { get; set; }
        public bool ShowHomesiteFilter { get; set; }
        public bool ShowHomesiteFilterForCommunity { get; set; }
        public bool IsHoverAllowed { get; set; }
        public bool ShowBottomBar { get; set; }
        public bool EnableHoverClickForUnreleased { get; set; }
        public bool HoldALot { get; set; }
        public string BuilderEmail { get; set; }
        public string BuilderDescription { get; set; }
        public List<HiddenSiteBlock> HiddenBlocks { get; set; }
        public List<HiddenLotConfiguration> HiddenLotConfigs { get; set; }
        public string HoldALotButtonText { get; set; }
        public string HoldALotHeaderText { get; set; }
    }
}