using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CDPAddCommunity")]
    public class SyncIdentityRequest
    {
        [DataMember(Name = "AddCommunity")]
        public CDPAddCommunity AddCommunity { get; set; }
        [DataMember(Name = "DeleteCommunities")]
        public List<int> DeleteCommunities { get; set; }
        [DataMember(Name = "AddBuilder")]
        public CDPAddBuilder AddBuilder { get; set; }
        [DataMember(Name = "DeleteBuilder")]
        public int DeleteBuilder { get; set; }
        [DataMember(Name = "AddHome")]
        public Listing AddHome { get; set; }
        [DataMember(Name = "DeleteHome")]
        public int DeleteHome { get; set; }
        [DataMember(Name = "CDPEvent")]
        public string CDPEvent { get; set; }
    }
}