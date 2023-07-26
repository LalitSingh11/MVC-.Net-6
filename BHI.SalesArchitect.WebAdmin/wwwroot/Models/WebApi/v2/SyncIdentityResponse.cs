using BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "SyncIdentityResponse")]
    public class SyncIdentityResponse
    {
        [DataMember(Name = "AddedCommunities")]
        public List<AddCommunityResponsePackage> AddedCommunities { get; set; }
        [DataMember(Name = "DeletedCommunities")]
        public List<int> DeletedCommunities { get; set; }
        [DataMember(Name = "AddedBuilders")]
        public List<ProspectBuilder> AddedBuilders { get; set; }
        [DataMember(Name = "DeletedBuilders")]
        public List<int> DeletedBuilders { get; set; }
        [DataMember(Name = "AddedHomes")]
        public List<CDPListingResponsePackage> AddedHomes { get; set; }
        [DataMember(Name = "DeletedHomes")]
        public List<int> DeletedHomes { get; set; }
    }
}