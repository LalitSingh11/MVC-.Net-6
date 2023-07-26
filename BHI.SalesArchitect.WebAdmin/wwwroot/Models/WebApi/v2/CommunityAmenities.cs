using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunityAmenities")]
    public class CommunityAmenities
    {
        [DataMember(Name = "Type")]
        public string Type { get; set; }
        [DataMember(Name = "TypeCode")]
        public string TypeCode { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Url")]
        public string Url { get; set; }
        [DataMember(Name = "Open")]
        public int Open { get; set; }

    }
}