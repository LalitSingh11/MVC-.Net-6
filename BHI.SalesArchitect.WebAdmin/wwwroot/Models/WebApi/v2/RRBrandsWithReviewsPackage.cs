using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "RRBrandsWithReviewsPackage")]
    public class RRBrandsWithReviewsPackage
    {
        [DataMember(Name = "TotalBrandCount")]
        public int TotalBrandCount { get; set; }
        [DataMember(Name = "Brands")]
        public List<RRBrandsWithReviews> Brands { get; set; }
    }
}