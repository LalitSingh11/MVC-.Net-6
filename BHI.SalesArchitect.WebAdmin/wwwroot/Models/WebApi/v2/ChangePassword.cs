using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "ChangePassword")]
    public class ChangePassword
    {
        [DataMember(Name = "ConsumerID")]
        public int ConsumerID { get; set; }
        [DataMember(Name = "NewPassword")]
        public string NewPassword { get; set; }
    }
}