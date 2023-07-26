using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "CommunityISPDetail")]
    public class CommunityISPDetail: BaseEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "HasActiveISP")]
        public bool HasActiveISP { get; set; }
        [DataMember(Name = "Version")]
        public int Version { get; set; }
    }
}