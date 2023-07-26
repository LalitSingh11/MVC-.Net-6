using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "Prospect")]
    public class ProspectConfiguration : BaseEntity
    {
        [DataMember(Name = "Phone")]
        public bool Phone { get; set; }
        [DataMember(Name = "ZipCode")]
        public bool ZipCode { get; set; }
        [DataMember(Name = "GuestCardNumber")]
        public bool GuestCardNumber { get; set; }
        [DataMember(Name = "MailingAddress")]
        public bool MailingAddress { get; set; }
        [DataMember(Name = "ReferralSources")]
        public bool ReferralSources { get; set; }
        [DataMember(Name = "RequestInfoModal")]
        public bool? RequestInfoModal { get; set; }
        [DataMember(Name ="EmailAllowed")]
        public bool EmailAllowed { get; set; }
        [DataMember(Name = "ShowBBNinvite")]
        public bool ShowBBNinvite { get; set; }

    }
}