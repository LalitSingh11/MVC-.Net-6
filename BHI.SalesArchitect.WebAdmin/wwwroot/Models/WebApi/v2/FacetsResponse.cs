using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "FacetsResponse")]
    public class FacetsResponse
    {
        [DataMember(Name = "PriceLow")]
        public int PriceLow { get; set; }
        [DataMember(Name = "PriceHigh")]
        public int PriceHigh { get; set; }
        [DataMember(Name = "SqftLow")]
        public int SqftLow { get; set; }
        [DataMember(Name = "SqftHigh")]
        public int SqftHigh { get; set; }
        [DataMember(Name = "Facets")]
        public List<SearchFilters> Facets { get; set; }

        public FacetsResponse()
        {
            PriceLow = 110000;
            PriceHigh = 1000000;
            SqftLow = 800;
            SqftHigh = 4000;
        }

    }
}