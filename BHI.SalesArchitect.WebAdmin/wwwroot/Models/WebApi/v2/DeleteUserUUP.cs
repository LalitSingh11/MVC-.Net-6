using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "DeleteUserUUP")]
    public class DeleteUserUUP
    {
        [DataMember(Name = "OrgId")]
        public int OrgId { get; set; }
        [DataMember(Name = "AccessToken")]
        public string AccessToken { get; set; }
    }
}