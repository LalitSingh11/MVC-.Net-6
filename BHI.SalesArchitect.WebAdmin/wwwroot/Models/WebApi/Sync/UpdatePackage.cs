using System.Collections.Generic;
using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "UpdatePackage")]
    public class UpdatePackage : BasePackage
    {

        public UpdatePackage()
        {
            Settings = new PartnerSettings();
        }
        [DataMember(Name = "Version")]
        public int Version { get; set; }
        [DataMember(Name = "DeleteActions")]
        public List<int> DeleteActions { get; set; }
        [DataMember(Name = "Actions")]
        public List<Action> Actions { get; set; }
        [DataMember(Name = "DeleteActivityStates")]
        public List<int> DeleteActivityStates { get; set; }
        [DataMember(Name = "ActivityStates")]
        public List<ActivityState> ActivityStates { get; set; }
        [DataMember(Name = "DeleteAssetTypes")]
        public List<int> DeleteAssetTypes { get; set; }
        [DataMember(Name = "AssetTypes")]
        public List<AssetType> AssetTypes { get; set; }
        [DataMember(Name = "DeleteBuilderBrandListings")]
        public List<int> DeleteBuilderBrandListings { get; set; }
        [DataMember(Name = "BuilderBrandListings")]
        public List<BuilderBrandListing> BuilderBrandListings { get; set; }
        [DataMember(Name = "DeleteBuilderBrands")]
        public List<int> DeleteBuilderBrands { get; set; }
        [DataMember(Name = "BuilderBrands")]
        public List<BuilderBrand> BuilderBrands { get; set; }
        [DataMember(Name = "DeleteCommunities")]
        public List<int> DeleteCommunities { get; set; }
        [DataMember(Name = "Communities")]
        public List<Community> Communities { get; set; }
        [DataMember(Name = "DeleteCommunityBuilderBrands")]
        public List<int> DeleteCommunityBuilderBrands { get; set; }
        [DataMember(Name = "CommunityBuilderBrands")]
        public List<CommunityBuilderBrand> CommunityBuilderBrands { get; set; }
        [DataMember(Name = "DeleteCommunityConfigurations")]
        public List<int> DeleteCommunityConfigurations { get; set; }
        [DataMember(Name = "CommunityConfigurations")]
        public List<CommunityConfiguration> CommunityConfigurations { get; set; }
        [DataMember(Name = "DeleteCommunityImages")]
        public List<int> DeleteCommunityImages { get; set; }
        [DataMember(Name = "CommunityImages")]
        public List<CommunityImage> CommunityImages { get; set; }
        [DataMember(Name = "DeleteCommunityAssets")]
        public List<int> DeleteCommunityAssets { get; set; }
        [DataMember(Name = "CommunityAssets")]
        public List<CommunityAsset> CommunityAssets { get; set; }
        [DataMember(Name = "DeleteCommunityPointOfInterests")]
        public List<int> DeleteCommunityPointOfInterests { get; set; }
        [DataMember(Name = "CommunityPointOfInterests")]
        public List<CommunityPointOfInterest> CommunityPointOfInterests { get; set; }
        [DataMember(Name = "DeleteSites")]
        public List<int> DeleteSites { get; set; }
        [DataMember(Name = "Sites")]
        public List<Site> Sites { get; set; }
        [DataMember(Name = "DeleteCommunitySites")]
        public List<int> DeleteCommunitySites { get; set; }
        [DataMember(Name = "CommunitySites")]
        public List<CommunitySite> CommunitySites { get; set; }
        [DataMember(Name = "DeleteCommunityUsers")]
        public List<int> DeleteCommunityUsers { get; set; }
        [DataMember(Name = "CommunityUsers")]
        public List<CommunityUser> CommunityUsers { get; set; }
        [DataMember(Name = "DeleteCommunityVideoTours")]
        public List<int> DeleteCommunityVideoTours { get; set; }
        [DataMember(Name = "CommunityVideoTours")]
        public List<CommunityVideoTour> CommunityVideoTours { get; set; }
        [DataMember(Name = "DeleteConfigurations")]
        public List<int> DeleteConfigurations { get; set; }
        [DataMember(Name = "Configurations")]
        public List<Configuration> Configurations { get; set; }
        [DataMember(Name = "DeleteListings")]
        public List<int> DeleteListings { get; set; }
        [DataMember(Name = "Listings")]
        public List<Listing> Listings { get; set; }
        [DataMember(Name = "DeleteListingAmenities")]
        public List<int> DeleteListingAmenities { get; set; }
        [DataMember(Name = "ListingAmenities")]
        public List<ListingAmenity> ListingAmenities { get; set; }
        [DataMember(Name = "DeleteListingImages")]
        public List<int> DeleteListingImages { get; set; }
        [DataMember(Name = "ListingImages")]
        public List<ListingImage> ListingImages { get; set; }
        [DataMember(Name = "DeleteLots")]
        public List<int> DeleteLots { get; set; }
        [DataMember(Name = "Lots")]
        public List<Lot> Lots { get; set; }
        [DataMember(Name = "DeleteLotListings")]
        public List<int> DeleteLotListings { get; set; }
        [DataMember(Name = "LotListings")]
        public List<LotListing> LotListings { get; set; }
        [DataMember(Name = "DeleteLotStates")]
        public List<int> DeleteLotStates { get; set; }
        [DataMember(Name = "LotStates")]
        public List<LotState> LotStates { get; set; }
        [DataMember(Name = "DeleteMarkets")]
        public List<int> DeleteMarkets { get; set; }
        [DataMember(Name = "Markets")]
        public List<Market> Markets { get; set; }
        [DataMember(Name = "DeletePartners")]
        public List<int> DeletePartners { get; set; }
        [DataMember(Name = "Partners")]
        public List<Partner> Partners { get; set; }
        [DataMember(Name = "Partner")]
        public Partner Partner { get; set; }
        [DataMember(Name = "DeletePartnerBuilderBrands")]
        public List<int> DeletePartnerBuilderBrands { get; set; }
        [DataMember(Name = "PartnerBuilderBrands")]
        public List<PartnerBuilderBrand> PartnerBuilderBrands { get; set; }
        [DataMember(Name = "DeletePartnerCommunities")]
        public List<int> DeletePartnerCommunities { get; set; }
        [DataMember(Name = "PartnerCommunities")]
        public List<PartnerCommunity> PartnerCommunities { get; set; }
        [DataMember(Name = "DeletePartnerListings")]
        public List<int> DeletePartnerListings { get; set; }
        [DataMember(Name = "PartnerListings")]
        public List<PartnerListing> PartnerListings { get; set; }
        [DataMember(Name = "DeletePointOfInterests")]
        public List<int> DeletePointOfInterests { get; set; }
        [DataMember(Name = "PointOfInterests")]
        public List<PointOfInterest> PointOfInterests { get; set; }
        [DataMember(Name = "DeleteProspects")]
        public List<int> DeleteProspects { get; set; }
        [DataMember(Name = "Prospects")]
        public List<Prospect> Prospects { get; set; }
        [DataMember(Name = "DeleteProspectListings")]
        public List<int> DeleteProspectListings { get; set; }
        [DataMember(Name = "ProspectListings")]
        public List<ProspectListing> ProspectListings { get; set; }
        [DataMember(Name = "DeleteProspectAssets")]
        public List<int> DeleteProspectAssets { get; set; }
        [DataMember(Name = "ProspectAssets")]
        public List<ProspectAsset> ProspectAssets { get; set; }
        [DataMember(Name = "DeleteProspectCommunities")]
        public List<int> DeleteProspectCommunities { get; set; }
        [DataMember(Name = "ProspectCommunities")]
        public List<ProspectCommunity> ProspectCommunities { get; set; }
        [DataMember(Name = "DeleteRoles")]
        public List<int> DeleteRoles { get; set; }
        [DataMember(Name = "Roles")]
        public List<Role> Roles { get; set; }
        [DataMember(Name = "DeleteRoleActions")]
        public List<int> DeleteRoleActions { get; set; }
        [DataMember(Name = "RoleActions")]
        public List<RoleAction> RoleActions { get; set; }
        [DataMember(Name = "DeleteUsers")]
        public List<int> DeleteUsers { get; set; }
        [DataMember(Name = "Users")]
        public List<User> Users { get; set; }
        [DataMember(Name = "DeleteUserRoles")]
        public List<int> DeleteUserRoles { get; set; }
        [DataMember(Name = "UserRoles")]
        public List<UserRole> UserRoles { get; set; }
        [DataMember(Name = "Settings")]
        public PartnerSettings Settings { get; set; }
        [DataMember(Name = "CommunityVideos")]
        public List<CommunityVideo> CommunityVideos { get; set; }
        [DataMember(Name = "ListingInteractiveMedias")]
        public List<ListingInteractiveMedia> ListingInteractiveMedias { get; set; }
        [DataMember(Name = "DeleteCommunityVideos")]
        public List<int> DeleteCommunityVideos { get; set; }
        [DataMember(Name = "DeleteListingInteractiveMedias")]
        public List<int> DeleteListingInteractiveMedias { get; set; }
        [DataMember(Name = "InteractiveMedias")]
        public List<InteractiveMedia> InteractiveMedias { get; set; }
        [DataMember(Name = "DeleteInteractiveMedias")]
        public List<int> DeleteInteractiveMedias { get; set; }
        [DataMember(Name = "LotStateConfigurations")]
        public List<LotStateConfiguration> LotStateConfigurations { get; set; }
        [DataMember(Name = "DeleteProspectLots")]
        public List<int> DeleteProspectLots { get; set; }
        [DataMember(Name = "ProspectLots")]
        public List<ProspectLot> ProspectLots { get; set; }
        [DataMember(Name = "ProspectReferralSources")]
        public List<ProspectReferralSource> ProspectReferralSources { get; set; }
        /// <summary>
        /// Referral Sources
        /// </summary>
        [DataMember(Name = "ReferralSources")]
        public List<ReferralSources> ReferralSources { get; set; }
        [DataMember(Name = "ProspectCommunityVisitDetails")]
        public List<ProspectCommunityVisitDetail> ProspectCommunityVisitDetails { get; set; }
        [DataMember(Name = "DeleteProspectCommunityVisitDetails")]
        public List<int> DeleteProspectCommunityVisitDetails { get; set; }

        /// <summary>
        /// Prospect Configuration
        /// </summary>
        [DataMember(Name = "ProspectConfigurations")]
        public List<ProspectConfiguration> ProspectConfigurations { get; set; }
        /// <summary>
        /// DeleteProspectConfiguration
        /// </summary>
        [DataMember(Name = "DeleteProspectConfigurations")]
        public List<int> DeleteProspectConfigurations { get; set; }
        /// <summary>
        /// DeleteProspectReferralSources
        /// </summary>
        [DataMember(Name = "DeleteProspectReferralSources")]
        public List<int> DeleteProspectReferralSources { get; set; }
        /// <summary>
        /// DeleteReferralSources
        /// </summary>
        [DataMember(Name = "DeleteReferralSources")]
        public List<int> DeleteReferralSources { get; set; }

    }
}