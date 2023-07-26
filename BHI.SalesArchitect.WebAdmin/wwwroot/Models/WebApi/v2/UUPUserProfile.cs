using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    public class UUPUserProfile
    {
        [DataMember(Name = "UserId")]
        public string UserId { get; set; }
        [DataMember(Name = "LogonName")]
        public string LogonName { get; set; }
        [DataMember(Name = "PartnerId")]
        public string PartnerId { get; set; }
        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "LastName")]
        public string LastName { get; set; }
        [DataMember(Name = "MiddleName")]
        public string MiddleName { get; set; }
        [DataMember(Name = "City")]
        public string City { get; set; }
        [DataMember(Name = "State")]
        public string State { get; set; }
        [DataMember(Name = "PostalCode")]
        public string PostalCode { get; set; }
        [DataMember(Name = "RegMetro")]
        public string RegMetro { get; set; }
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }
        [DataMember(Name = "LastLogon")]
        public string LastLogon { get; set; }
        //[DataMember(Name = "OutsideUS")]
        //public bool OutsideUS { get; set; }
        [DataMember(Name = "MarketOptIn")]
        public bool MarketOptIn { get; set; }
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "ID")]
        public int ID { get; set; }
        [DataMember(Name = "IsPasswordSet")]
        public bool IsPasswordSet { get; set; }
        [DataMember(Name = "OrgId")]
        public int OrgId { get; set; }
    }
}