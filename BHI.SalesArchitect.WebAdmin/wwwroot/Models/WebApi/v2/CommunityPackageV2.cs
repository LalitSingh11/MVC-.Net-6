using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using ApiSync = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunityPackageV2")]
    public class CommunityPackageV2 : CommunityPackage
    {
        [DataMember(Name = "SchoolDistricts")]
        public List<SchoolDistrict> SchoolDistricts { get; set; }
        [DataMember(Name = "CommunityAmenities")]
        public List<CommunityAmenityCategory> CommunityAmenities { get; set; }
        [DataMember(Name = "CommunityUtilities")]
        public List<CommunityUtilities> CommunityUtilities { get; set; }
        [DataMember(Name = "CommunitySalesOffice")]
        public CommunitySalesOffice CommunitySalesOffice { get; set; }
        [DataMember(Name = "CommunitySalesAgent")]
        public List<CommunitySalesAgent> CommunitySalesAgent { get; set; }
        [DataMember(Name = "TitleSettingsConfiguration")]
        public List<ApiSync.Configuration> TitleSettingsConfiguration { get; set; }
        [DataMember(Name = "HomeCount")]
        public int HomeCount { get; set; }
        [DataMember(Name = "QMICount")]
        public int QMICount { get; set; }
        [DataMember(Name = "BedLow")]
        public int BedLow { get; set; }
        [DataMember(Name = "BedHigh")]
        public int BedHigh { get; set; }
        [DataMember(Name = "BathLow")]
        public float BathLow { get; set; }
        [DataMember(Name = "BathHigh")]
        public float BathHigh { get; set; }
        [DataMember(Name = "GarageLow")]
        public int GarageLow { get; set; }
        [DataMember(Name = "GarageHigh")]
        public int GarageHigh { get; set; }
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }
        [DataMember(Name = "PhoneTracking")]
        public string PhoneTracking { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "HasVideos")]
        public bool HasVideos { get; set; }
        [DataMember(Name = "ShowAvailablePlans")]
        public bool ShowAvailablePlans { get; set; }
        [DataMember(Name = "CommunitySiteGeoJsonModel")]
        public CommunitySiteGeoJsons CommunitySiteGeoJsonModel { get; set; }
        [DataMember(Name = "HasAR")]
        public bool HasAR { get; set; }
        [DataMember(Name = "ProjectType")]
        public string ProjectType { get; set; }
        [DataMember(Name = "CommunityUrl")]
        public string CommunityUrl { get; set; }
        [DataMember(Name = "BrandSiteUrl")]
        public string BrandSiteUrl { get; set; }
        [DataMember(Name = "MPCBrands")]
        public List<ApiSync.BuilderSearch> MPCBrands { get; set; }
        [DataMember(Name = "CommunityName")]
        public string CommunityName { get; set; }
        [DataMember(Name = "BrandLogoSmall")]
        public string BrandLogoSmall { get; set; }
        [DataMember(Name = "BrandLogoMedium")]
        public string BrandLogoMedium { get; set; }
        [DataMember(Name = "PartnerName")]
        public string PartnerName { get; set; }
        [DataMember(Name = "Latitude")]
        public decimal? Latitude { get; set; }
        [DataMember(Name = "Longitude")]
        public decimal? Longitude { get; set; }
        [DataMember(Name = "BuilderBDXID")]
        public int BuilderBDXID { get; set; }
        [DataMember(Name = "MarketId")]
        public int MarketId { get; set; }       
        [DataMember(Name = "BuilderName")]
        public string BuilderName { get; set; }
        [DataMember(Name = "BDXCommunityId")]
        public int BDXCommunityId { get; set; }
        [DataMember(Name = "City")]
        public string City { get; set; }
        [DataMember(Name = "State")]
        public string State { get; set; }
        [DataMember(Name = "Zip")]
        public string Zip { get; set; }
        [DataMember(Name = "PriceLow")]
        public decimal? PriceLow { get; set; }
        [DataMember(Name = "PriceHigh")]
        public decimal? PriceHigh { get; set; }
        [DataMember(Name = "ShowMortgageLink")]
        public bool ShowMortgageLink { get; set; }
        [DataMember(Name = "MonthlyEMI")]
        public double MonthlyEMI { get; set; }
        [DataMember(Name = "MarketName")]
        public string MarketName { get; set; }
        [DataMember(Name = "MarketStateAbbr")]
        public string MarketStateAbbr { get; set; }
        [DataMember(Name = "BrandName")]
        public string BrandName { get; set; }
        [DataMember(Name = "BrandId")]
        public int BrandId { get; set; }
        [DataMember(Name = "AverageStarRating")]
        public decimal AverageStarRating { get; set; }
        [DataMember(Name = "CommunityStatus")]
        public string CommunityStatus { get; set; }
        [DataMember(Name = "SuppressPrice")]
        public bool SuppressPrice { get; set; }
        [DataMember(Name = "BannerAlertText1Bold")]
        public string BannerAlertText1Bold { get; set; }
        [DataMember(Name = "BannerAlertText2")]
        public string BannerAlertText2 { get; set; }
        [DataMember(Name = "BannerAlert")]
        public bool BannerAlert { get; set; }
        [DataMember(Name = "BannerAlertText3Header")]
        public string BannerAlertText3Header { get; set; }
        [DataMember(Name = "BannerAlertText4Bold")]
        public string BannerAlertText4Bold { get; set; }
        [DataMember(Name = "BannerAlertText5")]
        public string BannerAlertText5 { get; set; }
        [DataMember(Name = "ApplyForSpecDetails")]
        public bool ApplyForSpecDetails { get; set; }
        [DataMember(Name = "ApplyForPlanDetails")]
        public bool ApplyForPlanDetails { get; set; }
    }
}