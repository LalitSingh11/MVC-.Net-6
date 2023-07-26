using System.Collections.Generic;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "DataKeyValidationPackage")]
    public class DataKeyValidationPackage : BasePackage
    {
    }

    /// <summary>
    /// DataKeyInspectionPackage
    /// </summary>
    [DataContract(Name = "DataKeyInspectionPackage")]
    public class DataKeyInspectionPackage : BasePackage
    {
        /// <summary>
        /// Partner Having All Detail of partner
        /// </summary>
        [DataMember(Name = "Partner")]
        public Partner Partner { get; set; }

        /// <summary>
        /// PartnerBuilderBrands use to find out the relation between partner and builder brands
        /// </summary>
        [DataMember(Name = "PartnerBuilderBrands")]
        public List<PartnerBuilderBrand> PartnerBuilderBrands { get; set; }

        /// <summary>
        /// Partner specific settings
        /// </summary>
        [DataMember(Name = "Settings")]
        public PartnerSettings Settings { get; set; }

        /// <summary>
        /// list of users
        /// </summary>
        [DataMember(Name = "Users")]
        public List<User> Users { get; set; }

        /// <summary>
        /// for mapping between users and communities
        /// </summary>
        [DataMember(Name = "CommunityUsers")]
        public List<CommunityUser> CommunityUsers { get; set; }

        /// <summary>
        /// Role Mapping
        /// </summary>
        [DataMember(Name = "UserRoles")]
        public List<UserRole> UserRoles { get; set; }

        /// <summary>
        /// BuilderBrands
        /// </summary>
        [DataMember(Name = "BuilderBrands")]
        public List<BuilderBrand> BuilderBrands { get; set; }

        /// <summary>
        /// LotStates
        /// </summary>
        [DataMember(Name = "LotStates")]
        public List<LotState> LotStates { get; set; }

        /// <summary>
        /// Markets
        /// </summary>
        [DataMember(Name = "Markets")]
        public List<Market> Markets { get; set; }

        /// <summary>
        /// PartnerCommunities
        /// </summary>
        [DataMember(Name = "PartnerCommunities")]
        public List<PartnerCommunity> PartnerCommunities { get; set; }

        /// <summary>
        /// PartnerListings
        /// </summary>
        [DataMember(Name = "PartnerListings")]
        public List<PartnerListing> PartnerListings { get; set; }

        /// <summary>
        /// PointOfInterests
        /// </summary>
        [DataMember(Name = "PointOfInterests")]
        public List<PointOfInterest> PointOfInterests { get; set; }

        /// <summary>
        /// RoleActions
        /// </summary>
        [DataMember(Name = "RoleActions")]
        public List<RoleAction> RoleActions { get; set; }

        /// <summary>
        /// Roles
        /// </summary>
        [DataMember(Name = "Roles")]
        public List<Role> Roles { get; set; }


        /// <summary>
        /// Referral Sources
        /// </summary>
        [DataMember(Name = "ReferralSources")]
        public List<ReferralSources> ReferralSources { get; set; }

        /// <summary>
        /// Prospect Configuration
        /// </summary>
        [DataMember(Name = "ProspectConfiguration")]
        public ProspectConfiguration ProspectConfiguration { get; set; }

        /// <summary>
        /// ProspectReferralSources
        /// </summary>
        [DataMember(Name = "ProspectReferralSources")]
        public List<ProspectReferralSource> ProspectReferralSources { get; set; }

        /// <summary>
        /// Prospect
        /// </summary>
        [DataMember(Name = "Prospects")]
        public List<Prospect> Prospects { get; set; }

        /// <summary>
        /// Configurations
        /// </summary>
        [DataMember(Name = "Configurations")]
        public List<Configuration> Configurations { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [DataMember(Name = "Version")]
        public int Version { get; set; }

        /// <summary>
        /// LastUpdated
        /// </summary>
        [DataMember(Name = "LastUpdated")]
        public System.DateTime LastUpdated { get; set; }

    }

    /// <summary>
    /// UserCommunitiesPackage
    /// </summary>
    [DataContract(Name = "UserCommunitiesPackage")]
    public class UserCommunitiesPackage : BasePackage
    {
        /// <summary>
        /// Communities
        /// </summary>
        [DataMember(Name = "Communities")]
        public List<Community> Communities { get; set; }
    }

    /// <summary>
    /// UpdatePackageList
    /// </summary>
    [DataContract(Name = "UpdatePackages")]
    public class UpdatePackages
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "UpdatePackage")]
        public UpdatePackage updatePackage { get; set; }
    }

    /// <summary>
    /// SyncPackage
    /// </summary>
    [DataContract(Name = "SyncPackage")]
    public class SyncPackage : BasePackage
    {
        /// <summary>
        /// updatePackages
        /// </summary>
        [DataMember(Name = "updatePackages")]
        public List<UpdatePackages> updatePackages { get; set; }
    }
}