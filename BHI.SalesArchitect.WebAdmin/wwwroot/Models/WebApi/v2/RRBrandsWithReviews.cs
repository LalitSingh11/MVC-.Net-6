using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "RRBrandsWithReviews")]
    public class RRBrandsWithReviews
    {
        [DataMember(Name = "BrandId")]
        public int BrandId { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Logo")]
        public string Logo { get; set; }
        [DataMember(Name = "ReviewsCount")]
        public int ReviewsCount { get; set; }
        [DataMember(Name = "CommunityCount")]
        public int CommunityCount { get; set; }
        [DataMember(Name = "ReviewContent")]
        public string ReviewContent { get; set; }
    }
}