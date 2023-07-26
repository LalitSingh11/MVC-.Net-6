using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="User")]
    public class User : BaseEntity
    {
        [DataMember(Name = "UserName")]
        public string UserName { get; set; }
        [DataMember(Name = "Password")]
        public string Password { get; set; }
        [DataMember(Name = "Email")]
        public string Email { get; set; }
        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "LastName")]
        public string LastName { get; set; }
        [DataMember(Name = "ActivityStateID")]
        public int ActivityStateID { get; set; }
        [DataMember(Name = "PartnerID")]
        public int? PartnerID { get; set; }
        [DataMember(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

    }
}