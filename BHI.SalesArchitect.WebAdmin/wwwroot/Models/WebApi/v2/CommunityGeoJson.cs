using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunityGeoJson")]
    public class CommunityGeoJson
    {
        [DataMember(Name = "Type")]
        public string Type { get; set; }
        [DataMember(Name = "GeoJsonURL")]
        public string GeoJsonURL { get; set; }
        [DataMember(Name = "Version")]
        public string Version { get; set; }
    }
}