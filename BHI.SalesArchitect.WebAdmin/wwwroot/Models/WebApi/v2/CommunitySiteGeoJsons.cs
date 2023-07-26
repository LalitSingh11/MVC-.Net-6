using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Api = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunitySiteGeoJsons")]
    public class CommunitySiteGeoJsons 
    {
        [DataMember(Name = "CommunityGeoJson")]
        public List<CommunityGeoJson> CommunityGeoJson { get; set; }
        [DataMember(Name = "CommunitySite")]
        public Api.CommunitySite CommunitySite { get; set; }
    }
}