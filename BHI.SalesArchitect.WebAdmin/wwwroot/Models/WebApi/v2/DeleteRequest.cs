using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "DeleteRequest")]
    public class DeleteRequest
    {
        [DataMember(Name = "Ids")]
        public int[] Ids { get; set; }
        [DataMember(Name = "bdxCommunityID")]
        public int bdxCommunityID { get; set; }
        [DataMember(Name = "CDPEvent")]
        public string CDPEvent { get; set; }
    }
}