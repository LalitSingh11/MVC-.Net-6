using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Base
{
    [DataContract(Name = "ConsumerBase")]
    public class ConsumerBase :BDXEntity
    {
        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "LastName")]
        public string LastName { get; set; }
        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "FacebookEmail")]
        public string FacebookEmail { get; set; }

        [DataMember(Name = "FacebookID")]
        public string FacebookID { get; set; }

        [DataMember(Name = "GoogleEmail")]
        public string GoogleEmail { get; set; }

        [DataMember(Name = "GoogleID")]
        public string GoogleID { get; set; }

        [DataMember(Name = "DeviceToken")]
        public string DeviceToken { get; set; }

        [DataMember(Name = "RegistrationType")]
        public int RegistrationType { get; set; }

        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "AppleEmail")]
        public string AppleEmail { get; set; }
        [DataMember(Name = "AppleID")]
        public string AppleID { get; set; }
        [DataMember(Name = "UUPUserID")]
        public string UUPUserID { get; set; }
        [DataMember(Name = "IsSyncNeeded")]
        public bool IsSyncNeeded { get; set; }
    }
}