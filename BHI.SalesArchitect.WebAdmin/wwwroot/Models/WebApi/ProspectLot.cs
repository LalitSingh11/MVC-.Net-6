using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ProspectLot")]
    public class ProspectLot : BaseEntity
    {
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "LotID")]
        public int LotID { get; set; }
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }
        [DataMember(Name = "Sequence")]
        public int Sequence { get; set; }
        [DataMember(Name = "CDPEvent")]
        public string CDPEvent { get; set; }
    }
}