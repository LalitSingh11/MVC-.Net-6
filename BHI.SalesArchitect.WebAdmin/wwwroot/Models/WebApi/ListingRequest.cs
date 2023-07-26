using System;
using System.Runtime.Serialization;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    public class ListingRequest : PublicBaseEntity
    {
        [DataMember(Name = "CommunityReference")]
        public String CommunityReference { get; set; }
        [DataMember(Name = "SiteID")]
        public int?  SiteID { get; set; }
      
    }
}