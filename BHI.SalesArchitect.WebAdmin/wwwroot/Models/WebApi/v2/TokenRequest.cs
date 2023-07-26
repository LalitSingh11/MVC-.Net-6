using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name ="TokenRequest")]
    public class TokenRequest
    {
        [DataMember(Name = "RefreshToken")]
        public string RefreshToken { get; set; }

        [DataMember(Name = "ExistingToken")]
        public string ExistingToken { get; set; }
    }
}