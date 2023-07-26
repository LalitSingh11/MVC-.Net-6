using BHI.SalesArchitect.Model;
using System;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name ="ProspectListing")]
    public class ProspectListing : BaseEntity
    {
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }
        [DataMember(Name = "AddedDate")]
        public DateTime AddedDate { get; set; }
    }
}