using BHI.SalesArchitect.WebAdmin.Models.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "ProspectCommunity")]
    public class ProspectCommunityRequest: ProspectCommunityBase
    {
        public DateTime LastDateOfVisit { get; set; }
        public int ProspectID { get; set; }
        public int? UserID { get; set; }
        public int ActivityStateID { get; set; }
        public int PartnerID { get; set; }
        /// <summary>
        /// Private Notes For the consumer
        /// </summary>
        [DataMember(Name = "ConsumerPrivateNotes")]
        public string ConsumerPrivateNotes { get; set; }
        [DataMember(Name = "CDPEvent")]
        public string CDPEvent { get; set; }
    }
}