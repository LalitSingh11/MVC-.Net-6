using System.Collections.Generic;
using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class SiteOverview
    {
        public int PartnerID { get; set; }
        public string SelectedLotID { get; set; }
        public IEnumerable<MasterPlanCommunity> OtherCommunities { get; set; }
        public string MapData { get; set; }
        public IEnumerable<SiteOverviewLot> LotData { get; set; }
        public IEnumerable<SiteOverviewListing> DefaultListingData { get; set; }
        public Community Community { get; set; }
        public bool IsZipCodeRequired { get; set; }
        public bool RequestInfoModal { get; set; }
        public string BuilderBrandLogo { get; set; }
        public bool IsBuilderLogo { get; set; }
        public List<PartnerSetting> PartnerSettings { get; set; }
        public List<CommunityConfiguration> SiteMapConfigurations { get; set; }
        public List<CommunityConfiguration> Legends { get; set; }
        public bool NewIsp { get; set; }
        public bool showAllPlans { get; set; }
        public bool ShowAllSpecs { get; set; }
        public bool PartnerShowAllPlans { get; set; }
        public bool PartnerShowAllSpecs { get; set; }
        public bool HideAssignedPlans { get; set; }
        public bool HideAssignedSpecs { get; set; }
        public Dictionary<string, string> PopupConfiguration { get; set; }
        public bool SendLotIds { get; set; }
        public bool ShowHomesiteFilter { get; set; }
        public bool ShowHomesiteFilterForCommunity { get; set; }
        public bool IsHoverAllowed { get; set; }
        public bool ShowBottomBar { get; set; }
        public bool EnableHoverClickForUnreleased { get; set; }
        public bool HoldALot { get; set; }
        public string BuilderEmail { get; set; }
        public string BuilderDescription { get; set; }
        public bool SuppressPrice { get; set; }
        public List<PointOfInterest> PointOfInterests { get; set; }
        public object ParcelsData { get; set; }
        public object Amenities { get; set; }
        public int MasterPlanId { get; set; }
        public List<HiddenSiteBlock> HiddenBlocks { get; set; }
        public List<HiddenLotConfiguration> HiddenLotConfigs { get; set; }
        public string PartnerName { get; set; }
        public string CommunityName { get; set; }
        public string HoldALotButtonText { get; set; }
        public string HoldALotHeaderText { get; set; }
        public string LotOutlineColor { get; set; }
        public List<string> suppressPriceLotStatus { get; set; }
        public bool LotPremiumOptionalDisplay { get; set; }
        public bool SuppressBuilderLogo { get; set; }
        public bool SuppressBottomCommunityName { get; set; }
        public bool SuppressTopCommunityName { get; set; }
        public bool SuppressLotStatusForCommunity { get; set; }
        public bool DisplayLotList { get; set; }
        public bool CommunityDisplayLotList { get; set; }
        public bool DisplaySpecAddress { get; set; }
        public bool AddModelHomesBanner { get; set; }
        public string ModelHomeOpacity { get; set; }
        public string ModelHomeText { get; set; }
        public string ModelHomeBackgroundColor { get; set; }
        public string ModelHomeFontColor { get; set; }
        public bool ReplaceKeyIcon { get; set; }
        public string SpecOpacity { get; set; }
        public string SpecText { get; set; }
        public string SpecBackgroundColor { get; set; }
        public string SpecFontColor { get; set; }
        public bool OpenSpecDefault { get; set; }
        public string PDFDisclaimer { get; set; }
        public  string GeospatialPrintTemplate { get; set; }
        public int HoldALotAccount { get; set; }
        public ReservationPending ReservationPendingDetail { get; set; }
        public ReservationPending ReservedDetail { get; set; }
        public CustomizedMessaging CustomizedMessaging { get; set; }
        public EnvisionColorSchemeResponse EnvisionColorSchemeData { get; set; }
        public bool IsSecured { get; set; }
    }
}