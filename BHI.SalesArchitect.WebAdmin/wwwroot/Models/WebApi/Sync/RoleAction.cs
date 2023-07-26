using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="RoleAction")]
    public class RoleAction : BaseEntity
    {
        [DataMember(Name ="Allowed")]
        public bool Allowed { get; set; }
        [DataMember(Name = "RoleID")]
        public int RoleID { get; set; }
        [DataMember(Name = "ActionID")]
        public int ActionID { get; set; }
    }
}