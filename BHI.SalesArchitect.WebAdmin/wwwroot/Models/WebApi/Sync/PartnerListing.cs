using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="PartnerListing")]
    public class PartnerListing : BaseEntity
    {
        [DataMember(Name ="PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
    }
}