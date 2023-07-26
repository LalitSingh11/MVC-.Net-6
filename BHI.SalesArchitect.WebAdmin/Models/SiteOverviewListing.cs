using BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;
using System.Collections.Generic;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class SiteOverviewListing
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public decimal? basePrice { get; set; }
        public int? bedrooms { get; set; }
        public decimal? baths { get; set; }
        public decimal? garage { get; set; }
        public int? baseSquareFeet { get; set; }
        public string defaultImageUrl { get; set; }
        public bool isAssigned { get; set; }
        public string builderListingUrl { get; set; }
        public decimal Price { get; set; }
        public int BDXID { get; set; }
        public List<SiteOverViewListingImage> images { get; set; }
        public string vendorReference { get; set; }
        public List<ListingInteractiveMedia> interactiveMedias { get; set; }
        public int BDXCommunityID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}