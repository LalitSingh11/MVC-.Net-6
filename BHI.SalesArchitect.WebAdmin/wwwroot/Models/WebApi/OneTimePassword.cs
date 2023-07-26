using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "OneTimePassword")]
    public class OneTimePassword : PublicRequestPackage
    {
        [DataMember(Name = "OTP")]
        public string OTP { get; set; }
        [DataMember(Name = "CreatedTime")]
        public DateTime CreatedTime { get; set; }
        [DataMember(Name = "ConsumerID")]
        public int ConsumerID { get; set; }
        [DataMember(Name = "IsExpired")]
        public bool IsExpired { get; set; }
    }
    [DataContract(Name ="ValidatePassword")]
    public class ValidatePassword : PublicRequestPackage
    {
        [DataMember(Name = "OTP")]
        public string OTP { get; set; }
        [DataMember(Name = "ConsumerID")]
        public int ConsumerID { get; set; }
        [DataMember(Name = "NewPassword")]
        public string NewPassword { get; set; }

    }
}