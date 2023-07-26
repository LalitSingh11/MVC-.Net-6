using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ListingElevationImage")]
    public class ListingElevationImage
    {
        [DataMember(Name = "ElevationImageID")]
        public int ID { get; set; }
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "ListingName")]
        public string ListingName { get; set; }
        [DataMember(Name = "Type")]
        public string Type { get; set; }
        [DataMember(Name = "Title")]
        public string Title { get; set; }
        [DataMember(Name = "URL")]
        public string URL { get; set; }
    }
}