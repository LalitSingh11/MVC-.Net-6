using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "ChangePasswordUUP")]
    public class ChangePasswordUUP
	{
        [DataMember(Name = "Organization")]
        public Organization Organization { get; set; }
        [DataMember(Name = "Email")]
        public string Email { get; set; }
        [DataMember(Name = "Password")]
        public string Password { get; set; }
	}

    [DataContract(Name = "Organization")]
    public class Organization
    {
        [DataMember(Name = "OrgId")]
        public int OrgId { get; set; }
    }
}