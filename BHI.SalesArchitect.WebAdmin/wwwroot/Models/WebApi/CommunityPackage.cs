using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Api = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;
using WebApi = BHI.SalesArchitect.WebAdmin.Models.WebApi;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "CommunityPackage")]
    public class CommunityPackage
    {
        [DataMember(Name = "communityVersion")]
        public Api.CummunityVersion communityVersion { get; set; }
        [DataMember(Name = "communityAssets")]
        public List<Api.CommunityAsset> communityAssets { get; set; }
        [DataMember(Name = "communityVideos")]
        public List<Api.CommunityVideo> communityVideos { get; set; }
        [DataMember(Name = "PartnerSettings")]
        public Api.PartnerSettings PartnerSettings { get; set; }
        [DataMember(Name = "interactiveMedias")]
        public List<Api.InteractiveMedia> interactiveMedias { get; set; }
        [DataMember(Name = "communityImages")]
        public List<Api.CommunityImage> communityImages { get; set; }
        [DataMember(Name = "lotListings")]
        public List<Api.LotListing> lotListings { get; set; }
        [DataMember(Name = "listings")]
        public List<Listing> listings { get; set; }
        [DataMember(Name = "listingAmenities")]
        public List<Api.ListingAmenity> listingAmenities { get; set; }
        [DataMember(Name = "listingImages")]
        public List<Api.ListingImage> listingImages { get; set; }
        [DataMember(Name = "listingInteractiveMedias")]
        public List<Api.ListingInteractiveMedia> listingInteractiveMedias { get; set; }
        [DataMember(Name = "communitySites")]
        public List<Api.CommunitySite> communitySites { get; set; }
        [DataMember(Name = "lots")]
        public List<Lotv2> lots { get; set; }
        [DataMember(Name = "lotStateConfiguration")]
        public List<Api.LotStateConfiguration> lotStateConfiguration { get; set; }
        [DataMember(Name = "builderBrandListings")]
        public List<Api.BuilderBrandListing> builderBrandListings { get; set; }

        [DataMember(Name = "communityPointOfInterests")]
        public List<Api.CommunityPointOfInterest> communityPointOfInterests { get; set; }
        [DataMember(Name = "deleteEntities")]
        public List<WebApi.DeleteEntityModal> deleteEntities { get; set; }
    }
}