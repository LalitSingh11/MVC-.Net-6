using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "FacetsRequest")]
    public class LeadResponse
    {
        [DataMember(Name = "Response")]
        public string Response { get; set; }
        [DataMember(Name = "RecoCommunities")]
        public List<Sync.SearchCommunityResponse> RecoCommunities { get; set; }
        [DataMember(Name = "IsLeadSubmittedWithinTimeFrameOfNotificationTap")]
        public bool IsLeadSubmittedWithinTimeFrameOfNotificationTap { get; set; }
    }
}