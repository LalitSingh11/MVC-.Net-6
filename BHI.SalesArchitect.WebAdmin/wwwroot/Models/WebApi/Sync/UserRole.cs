using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="UserRole")]
    public class UserRole : BaseEntity
    {
        [DataMember(Name ="UserID")]
        public int UserID { get; set; }
        [DataMember(Name = "RoleID")]
        public int RoleID { get; set; }
    }
}