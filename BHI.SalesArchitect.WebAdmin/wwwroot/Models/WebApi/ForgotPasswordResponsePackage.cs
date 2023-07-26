using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ForgotPasswordResponsePackage")]
    public class ForgotPasswordResponsePackage
    {
        [DataMember(Name = "ConsumerID")]
        public int ConsumerID { get; set; }
        [DataMember(Name = "Message")]
        public string Message { get; set; }
    }
}