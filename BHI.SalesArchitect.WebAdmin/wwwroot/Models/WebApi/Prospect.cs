using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "Prospect")]
    public class Prospect : BaseEntity
    {
        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "LastName")]
        public string LastName { get; set; }
        [DataMember(Name = "Email")]
        public string Email { get; set; }
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }
        [DataMember(Name = "ZipCode")]
        public string ZipCode { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "State")]
        public string State { get; set; }
        [DataMember(Name = "City")]
        public string City { get; set; }
        [DataMember(Name = "CardNumber")]
        public string CardNumber { get; set; }
        [DataMember(Name = "AccessKey")]
        public string AccessKey { get; set; }
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }
        [DataMember(Name = "WelcomeImageObject")]
        public HttpPostedFileBase WelcomeImageObject { get; set; }
        [DataMember(Name = "WelcomeImage")]
        public string WelcomeImage { get; set; }
        [DataMember(Name = "SalesUserID")]
        public int SalesUserID { get; set; }
        [DataMember(Name = "AppUsage")]
        public decimal AppUsage { get; set; }
        [DataMember(Name = "NHNInvite")]
        public int? NHNInvite { get; set; }
        [DataMember(Name = "BBNInvite")]
        public int? BBNInvite { get; set; }
    }
}
