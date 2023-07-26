using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "LimitedAvailability")]
    public class LimitedAvailability
    {
        [DataMember(Name = "LimitedAvailabilityListingsList")]
        public List<Limitedavailabilitylistingslist> LimitedAvailabilityListingsList { get; set; }
    }
    [DataContract(Name = "Limitedavailabilitylistingslist")]
    public class Limitedavailabilitylistingslist
    {
        [DataMember(Name = "BrandId")]
        public int BrandId { get; set; }
        [DataMember(Name = "BuilderName")]
        public string BuilderName { get; set; }
        [DataMember(Name = "LimitedAvailabilityListingInfo")]
        public List<Limitedavailabilitylistinginfo> LimitedAvailabilityListingInfo { get; set; }
    }
    [DataContract(Name = "Limitedavailabilitylistinginfo")]
    public class Limitedavailabilitylistinginfo
    {
        [DataMember(Name = "CommunityId")]
        public int CommunityId { get; set; }
        [DataMember(Name = "CommunityName")]
        public string CommunityName { get; set; }
        [DataMember(Name = "BannerAlertText1Bold")]
        public string BannerAlertText1Bold { get; set; }
        [DataMember(Name = "BannerAlertText2")]
        public string BannerAlertText2 { get; set; }
        [DataMember(Name = "SuppressPrice")]
        public string SuppressPrice { get; set; }
        [DataMember(Name = "ApplyForSpecDetails")]
        public string ApplyForSpecDetails { get; set; }
        [DataMember(Name = "ApplyForPlanDetails")]
        public string ApplyForPlanDetails { get; set; }
        [DataMember(Name = "BannerAlert")]
        public string BannerAlert { get; set; }
    }
}