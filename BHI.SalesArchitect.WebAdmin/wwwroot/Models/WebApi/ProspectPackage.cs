using BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Api = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;
using WebApi = BHI.SalesArchitect.WebAdmin.Models.WebApi;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ProspectPackage")]
    public class ProspectPackage
    {
        [DataMember(Name = "Prospect")]
        public List<Api.Prospect> Prospect { get; set; }
        [DataMember(Name = "ProspectCommunities")]
        public List<Api.ProspectCommunity> ProspectCommunities { get; set; }
        [DataMember(Name = "ProspectAssets")]
        public List<Api.ProspectAsset> ProspectAssets { get; set; }
        [DataMember(Name = "ProspectListings")]
        public List<Api.ProspectListing> ProspectListings { get; set; }
        [DataMember(Name = "ProspectLots")]
        public List<ProspectLot> ProspectLots { get; set; }
        [DataMember(Name = "ProspectCommunityVisitDetails")]
        public List<ProspectCommunityVisitDetail> ProspectCommunityVisitDetails { get; set; }
        [DataMember(Name = "ConsumerAppResources")]
        public List<ConsumerAppResource> ConsumerAppResources { get; set; }
        [DataMember(Name = "PointOfInterests")]
        public List<Api.PointOfInterest> PointOfInterests { get; set; }
        [DataMember(Name = "MyFavorites")]
        public List<Listing> MyFavorites { get; set; }
        [DataMember(Name = "ProspectBuilders")]
        public List<ProspectBuilder> ProspectBuilders { get; set; }
        [DataMember(Name = "CDPDataPosted")]
        public bool CDPDataPosted { get; set; }
    }
}