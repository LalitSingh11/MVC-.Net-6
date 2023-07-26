using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "FacetsRequest")]
    public class FacetsRequest
    {
        [DataMember(Name = "PartnerId")]
        public int PartnerId { get; set; }
        [DataMember(Name = "MarketId")]
        public int? MarketId { get; set; }
        [DataMember(Name = "OriginLat")]
        public Decimal? OriginLat { get; set; }
        [DataMember(Name = "OriginLng")]
        public Decimal? OriginLng { get; set; }
        [DataMember(Name = "Radius")]
        public int? Radius { get; set; }
        [DataMember(Name = "SearchType")]
        public string SearchType { get; set; }
        [DataMember(Name = "includeMPC")]
        public bool includeMPC { get; set; }
        [DataMember(Name = "CommunityIds")]
        public List<int> CommunityIds { get; set; }
    }
}