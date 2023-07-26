using System;
using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
using BHI.SalesArchitect.WebAdmin.Models.WebApi.Base;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "ProspectCommunity")]
    public class ProspectCommunity : ProspectCommunityBase
    {
        [DataMember(Name = "LastDateOfVisit")]
        public DateTime LastDateOfVisit { get; set; }
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "UserID")]
        public int? UserID { get; set; }
        [DataMember(Name = "ActivityStateID")]
        public int ActivityStateID { get; set; }
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }
        [DataMember(Name = "SalesUser")]
        public User SalesUser { get; set; }
        
        /// <summary>
        /// Private Notes For the builder
        /// </summary>
        [DataMember(Name = "PrivateNotes")]
        public string PrivateNotes { get; set; }
        [DataMember(Name = "AddedDate")]
        public DateTime AddedDate { get; set; }
        [DataMember(Name = "AddSource")]
        public int AddSource { get; set; }
    }
}