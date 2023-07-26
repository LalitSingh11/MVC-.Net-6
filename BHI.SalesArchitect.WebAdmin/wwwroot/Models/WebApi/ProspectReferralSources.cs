using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    public class ProspectReferralSource : BaseEntity
    {
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "ReferralSourceID")]
        public int ReferralSourceId { get; set; }
        [DataMember(Name = "CustomValue")]
        public string CustomValue { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }
    }
}