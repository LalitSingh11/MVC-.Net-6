using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "AddCommunityResponsepackage")]
    public class AddCommunityResponsePackage
    {
        [DataMember(Name = "Community")]
        public Sync.Community Community { get; set; }
        [DataMember(Name = "ProspectCommunity")]
        public Sync.ProspectCommunity ProspectCommunity { get; set; }
        [DataMember(Name = "IsAlreadyAdded")]
        public bool IsAlreadyAdded { get; set; }
    }
}