using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "RRAreasWithReviewsPackage")]
    public class RRAreasWithReviewsPackage
    {
        [DataMember(Name = "TotalBrandCount")]
        public int TotalBrandCount { get; set; }
        [DataMember(Name = "MarketAreas")]
        public List<RRMarketLocation> MarketAreas { get; set; }
    }
}