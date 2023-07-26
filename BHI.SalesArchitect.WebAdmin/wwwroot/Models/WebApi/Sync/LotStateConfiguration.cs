using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="LotStateConfiguration")]
    public class LotStateConfiguration
    {
        [DataMember(Name = "LotStateID")]
        public int LotStateID { get; set; }

        [DataMember(Name = "Color")]
        public string Color { get; set; }
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "StatusName")]
        public string StatusName { get; set; }
        [DataMember(Name = "IsActive")]
        public bool IsActive { get; set; }
    }
}
 
