using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class Partner
{
    public int Id { get; set; }

    public int Bdxid { get; set; }

    public string Name { get; set; }

    public string UploadDataMappingConfiguration { get; set; }

    public string DataKey { get; set; }

    public int Type { get; set; }

    public int? MappedPartnerId { get; set; }

    public string LeadPostingPassword { get; set; }

    public string Ispname { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<BuilderBrandListing> BuilderBrandListings { get; set; } = new List<BuilderBrandListing>();

    public virtual ICollection<CommunityBuilderBrand> CommunityBuilderBrands { get; set; } = new List<CommunityBuilderBrand>();

    public virtual ICollection<CommunityImage> CommunityImages { get; set; } = new List<CommunityImage>();

    public virtual ICollection<CommunityVideoTour> CommunityVideoTours { get; set; } = new List<CommunityVideoTour>();

    public virtual ICollection<CommunityVideo> CommunityVideos { get; set; } = new List<CommunityVideo>();

    public virtual ICollection<Configuration> Configurations { get; set; } = new List<Configuration>();

    public virtual ICollection<ConsumerAppConfigurable> ConsumerAppConfigurables { get; set; } = new List<ConsumerAppConfigurable>();

    public virtual ICollection<ConsumerAppResource> ConsumerAppResources { get; set; } = new List<ConsumerAppResource>();

    public virtual ICollection<Consumer> Consumers { get; set; } = new List<Consumer>();

    public virtual ICollection<DataImportTime> DataImportTimes { get; set; } = new List<DataImportTime>();

    public virtual ICollection<InteractiveMedium> InteractiveMedia { get; set; } = new List<InteractiveMedium>();

    public virtual ICollection<ListingAmenity> ListingAmenities { get; set; } = new List<ListingAmenity>();

    public virtual ICollection<ListingImage> ListingImages { get; set; } = new List<ListingImage>();

    public virtual ICollection<ListingInteractiveMedium> ListingInteractiveMedia { get; set; } = new List<ListingInteractiveMedium>();

    public virtual ICollection<LotState> LotStates { get; set; } = new List<LotState>();

    public virtual ICollection<PartnerBuilderBrand> PartnerBuilderBrands { get; set; } = new List<PartnerBuilderBrand>();

    public virtual ICollection<PartnerCommunity> PartnerCommunities { get; set; } = new List<PartnerCommunity>();

    public virtual ICollection<PartnerListing> PartnerListings { get; set; } = new List<PartnerListing>();

    public virtual ICollection<PartnerMasterPlan> PartnerMasterPlans { get; set; } = new List<PartnerMasterPlan>();

    public virtual ICollection<PartnerSetting> PartnerSettings { get; set; } = new List<PartnerSetting>();

    public virtual ICollection<ProspectConfiguration> ProspectConfigurations { get; set; } = new List<ProspectConfiguration>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
