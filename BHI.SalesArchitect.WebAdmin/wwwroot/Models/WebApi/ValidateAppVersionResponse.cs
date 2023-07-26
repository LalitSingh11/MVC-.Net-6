using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ValidateAppVersionResponse")]
    public class ValidateAppVersionResponse
    {
        [DataMember(Name = "Status")]
        public int Status { get; set; }
        [DataMember(Name = "Message")]
        public string Message { get; set; }
    }
}