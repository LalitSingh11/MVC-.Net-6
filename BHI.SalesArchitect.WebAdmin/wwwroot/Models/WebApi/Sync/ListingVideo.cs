using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "ListingVideo")]
    public class ListingVideo : BaseEntity
    {
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "BDXListingID")]
        public int BDXListingID { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }

        [DataMember(Name = "URL")]
        public string URL { get; set; }
        [DataMember(Name = "Title")]
        public string Title { get; set; }
        [DataMember(Name = "Category")]
        public string Category { get; set; }
        [DataMember(Name = "Thumbnail")]
        public string Thumbnail { get; set; }
    }
}