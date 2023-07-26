using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CDPAddBuilder")]
    public class CDPAddBuilder
    {
        [DataMember(Name = "BuilderId")]
        public int BuilderId { get; set; }
        [DataMember(Name = "Source")]
        public int Source { get; set; }
    }
}