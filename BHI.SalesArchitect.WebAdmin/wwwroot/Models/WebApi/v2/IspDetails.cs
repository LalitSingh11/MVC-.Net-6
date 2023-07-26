using BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Sync = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "IspDetails")]
    public class IspDetails
    {
        [DataMember(Name = "communitySites")]
        public List<Sync.CommunitySite> communitySites { get; set; }
        [DataMember(Name = "lots")]
        public List<Lotv2> lots { get; set; }
        [DataMember(Name = "lotStateConfiguration")]
        public List<LotStateConfiguration> lotStateConfiguration { get; set; }
        [DataMember(Name = "TitleSettingsConfiguration")]
        public List<Configuration> TitleSettingsConfiguration { get; set; }
        [DataMember(Name = "lotListings")]
        public List<LotListing> lotListings { get; set; }
        [DataMember(Name = "CommunitySiteGeoJsonModel")]
        public CommunitySiteGeoJsons CommunitySiteGeoJsonModel { get; set; }
    }
}