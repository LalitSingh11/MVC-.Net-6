using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "RRBuilderReviewsPackage")]
    public class RRBuilderReviewsPackage
    {
        [DataMember(Name = "AverageRating")]
        public float AverageRating { get; set; }
        [DataMember(Name = "TotalReviewCount")]
        public int TotalReviewCount { get; set; }
        [DataMember(Name = "Reviews")]
        public List<RRReviews> Reviews { get; set; }
    }
}