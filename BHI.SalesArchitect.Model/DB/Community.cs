using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class Community
{
    public int Id { get; set; }

    public int Bdxid { get; set; }

    public int MarketId { get; set; }

    public int ActivityStateId { get; set; }

    public string Name { get; set; } = null!;

    public string? Admins { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? BrandLogoMedium { get; set; }

    public string? BrandLogoSmall { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Phone { get; set; }

    public string? SubDescription { get; set; }

    public string? Overview { get; set; }

    public bool Locked { get; set; }

    public string? VendorReference { get; set; }

    public int? MasterPlanId { get; set; }

    public string? CustomDescription { get; set; }

    public string? EnvisionDesignCenter { get; set; }

    public string? Hours { get; set; }

    public int? PreferredCommunityAssetId { get; set; }

    public bool? NewIsp { get; set; }

    public string? DisplayName { get; set; }

    public bool? IsOverwriteName { get; set; }

    public int? Dwstatus { get; set; }

    public byte GeospatialZoomLevel { get; set; }

    public bool Status { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int? UpdatedBy { get; set; }

    public string? Ispname { get; set; }

    public virtual ActivityState ActivityState { get; set; } = null!;

    public virtual ICollection<BuilderBrandListing> BuilderBrandListings { get; set; } = new List<BuilderBrandListing>();

    public virtual ICollection<CommunityBuilderBrand> CommunityBuilderBrands { get; set; } = new List<CommunityBuilderBrand>();

    public virtual ICollection<CommunityConfiguration> CommunityConfigurations { get; set; } = new List<CommunityConfiguration>();

    public virtual ICollection<CommunityImage> CommunityImages { get; set; } = new List<CommunityImage>();

    public virtual ICollection<CommunityNearByPoi> CommunityNearByPois { get; set; } = new List<CommunityNearByPoi>();

    public virtual ICollection<CommunityPointOfInterest> CommunityPointOfInterests { get; set; } = new List<CommunityPointOfInterest>();

    public virtual ICollection<CommunitySiteGeoJson> CommunitySiteGeoJsons { get; set; } = new List<CommunitySiteGeoJson>();

    public virtual ICollection<CommunitySite> CommunitySites { get; set; } = new List<CommunitySite>();

    public virtual ICollection<CommunityUser> CommunityUsers { get; set; } = new List<CommunityUser>();

    public virtual ICollection<CommunityVideoTour> CommunityVideoTours { get; set; } = new List<CommunityVideoTour>();

    public virtual ICollection<CommunityVideo> CommunityVideos { get; set; } = new List<CommunityVideo>();

    public virtual ICollection<InteractiveMedium> InteractiveMedia { get; set; } = new List<InteractiveMedium>();

    public virtual Market Market { get; set; } = null!;

    public virtual MasterPlan? MasterPlan { get; set; }

    public virtual ICollection<PartnerCommunity> PartnerCommunities { get; set; } = new List<PartnerCommunity>();

    public virtual ICollection<ProspectCommunity> ProspectCommunities { get; set; } = new List<ProspectCommunity>();

    public virtual ICollection<ProspectLot> ProspectLots { get; set; } = new List<ProspectLot>();
}
