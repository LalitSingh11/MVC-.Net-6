using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    public class SearchCommunityRequest
    {
        public int PartnerId { get; set; }
        public List<int> CommunityIds { get; set; }
        public int? BuilderId { get; set; }
        public PagingRequest Paging { get; set; }
        public int? BrandId { get; set; }
        public int? MarketId { get; set; }
        public List<int> Brands { get; set; }
        public Decimal? OriginLat { get; set; }
        public Decimal? OriginLng { get; set; }
        public int? Radius { get; set; }
        public int? Bed { get; set; }
        public int? Bath { get; set; }
        public int? PriceLow { get; set; }
        public int? PriceHigh { get; set; }
        public int? SqftLow { get; set; }
        public int? SqftHigh { get; set; }
        public List<int> SchoolDistricts { get; set; }
        public bool? SpecialOffers { get; set; }
        public string HomeType { get; set; }
        public string CommStatus { get; set; }
        public string BuilderType { get; set; }
        public List<string> Amenities { get; set; }
        public string HomeStatus { get; set; }
        public int? MasterBedroom { get; set; }
        public int? Garage { get; set; }
        public int? Stories { get; set; }
        public int? LivingArea { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool includeMPC { get; set; }
        public bool HasBuilderReviews { get; set; }
        public bool HasRVGarage { get; set; }
        public SearchCommunityRequest()
        {
            Paging = new PagingRequest()
            {
                page = 1,
                PageSize = 100,
                SortBy = "Random"
            };
            Radius = 3;//Default to 3 miles
        }
    }
}