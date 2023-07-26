using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="CommunityUser")]
    public class CommunityUser : BaseEntity
    {
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "UserID")]
        public int UserID { get; set; }
        [DataMember(Name = "ActivityStateID")]
        public int ActivityStateID { get; set; }
    }
}