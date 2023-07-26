using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    public class GADetails
    {
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "PartnerName")]
        public string PartnerName { get; set; }
        [DataMember(Name = "CommunityName")]
        public string CommunityName { get; set; }
        [DataMember(Name = "BDXBuilderID")]
        public int BDXBuilderID { get; set; }
    }
}