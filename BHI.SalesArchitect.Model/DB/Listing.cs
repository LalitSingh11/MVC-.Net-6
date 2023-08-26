using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class Listing
{
    public int Id { get; set; }

    public int Bdxid { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Address { get; set; }

    public string    City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public decimal? BasePrice { get; set; }

    public int? Bedrooms { get; set; }

    public decimal? Baths { get; set; }

    public int? BaseSquareFeet { get; set; }

    public decimal? Garage { get; set; }

    public int? Stories { get; set; }

    public string MasterBedLocation { get; set; }

    public string VirtualTour { get; set; }

    public string PlanType { get; set; }

    public int? LivingAreas { get; set; }

    public int? DiningAreas { get; set; }

    public bool? Basement { get; set; }

    public string EnvisionDesignCenter { get; set; }

    public string Description { get; set; }

    public string VendorReference { get; set; }

    public string BuilderListingUrl { get; set; }

    public virtual ICollection<BuilderBrandListing> BuilderBrandListings { get; set; } = new List<BuilderBrandListing>();

    public virtual ICollection<ListingAmenity> ListingAmenities { get; set; } = new List<ListingAmenity>();

    public virtual ICollection<ListingImage> ListingImages { get; set; } = new List<ListingImage>();

    public virtual ICollection<ListingInteractiveMedium> ListingInteractiveMedia { get; set; } = new List<ListingInteractiveMedium>();

    public virtual ICollection<LotListing> LotListings { get; set; } = new List<LotListing>();

    public virtual ICollection<PartnerListing> PartnerListings { get; set; } = new List<PartnerListing>();

    public virtual ICollection<ProspectAsset> ProspectAssets { get; set; } = new List<ProspectAsset>();

    public virtual ICollection<ProspectListing> ProspectListings { get; set; } = new List<ProspectListing>();
}
