using BHI.SalesArchitect.WebAdmin.Models.WebApi.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Api = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ListingPackage")]
    public class ListingPackage
    {
        [DataMember(Name = "ListingAmenities")]
        public List<Api.ListingAmenity> ListingAmenities { get; set; }
        [DataMember(Name = "ListingImages")]
        public List<Api.ListingImage> ListingImages { get; set; }
        [DataMember(Name = "ListingInteractiveMedias")]
        public List<Api.ListingInteractiveMedia> ListingInteractiveMedias { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "ListingVideos")]
        public List<Api.ListingVideo> ListingVideos { get; set; }
        [DataMember(Name = "Listing")]
        public Listing Listing { get; set; }
        [DataMember(Name = "LivingAreas")]
        public List<LivingAreas> LivingAreas { get; set; }
        [DataMember(Name = "PlanAmenities")]
        public List<PlanAmenities> PlanAmenities { get; set; }
        [DataMember(Name = "hasAssignedLots")]
        public bool hasAssignedLots { get; set; }
        [DataMember(Name = "ARHomeViewer")]
        public AugmentedRealityHomeViewer ARHomeViewer { get; set; }
        [DataMember(Name = "ARHomeOnLot")]
        public AugmentedRealityHomeOnLot ARHomeOnLot { get; set; }
        [DataMember(Name = "GuidedTourUrl")]
        public string GuidedTourUrl { get; set; }
        [DataMember(Name = "ShowMortgageLink")]
        public bool ShowMortgageLink { get; set; }
        [DataMember(Name = "MonthlyEMI")]
        public double MonthlyEMI { get; set; }
        [DataMember(Name = "MarketName")]
        public string MarketName { get; set; }
        [DataMember(Name = "MarketStateAbbr")]
        public string MarketStateAbbr { get; set; }
        [DataMember(Name = "AverageStarRating")]
        public decimal AverageStarRating { get; set; }
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