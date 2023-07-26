using BHI.SalesArchitect.Model;
using System;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
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
        [DataMember(Name = "HomePhone")]
        public string HomePhone { get; set; }
        [DataMember(Name = "MobilePhone")]
        public string MobilePhone { get; set; }
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
        [DataMember(Name = "ZipCode")]
        public string ZipCode { get; set; }
        [DataMember(Name = "LastDateOfVisit")]
        public DateTime LastDateOfVisit { get; set; }
        [DataMember(Name = "WelcomeImage")]
        public string WelcomeImage { get; set; }
        [DataMember(Name = "AppUsage")]
        public decimal AppUsage { get; set; }
        [DataMember(Name = "Password")]
        public string Password { get; set; }
        [DataMember(Name = "OldPassword")]
        public string OldPassword { get; set; }
        [DataMember(Name = "IsPasswordSet")]
        public bool IsPasswordSet { get; set; }
        [DataMember(Name = "MarketOptIn")]
        public bool MarketOptIn { get; set; }
    }
}