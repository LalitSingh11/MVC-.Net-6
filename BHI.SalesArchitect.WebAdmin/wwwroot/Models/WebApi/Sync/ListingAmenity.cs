using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="ListingAmenity")]
    public class ListingAmenity : BaseEntity
    {
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "Amenity")]
        public string Amenity { get; set; }
        [DataMember(Name = "Count")]
        public int? Count { get; set; }
        [DataMember(Name = "BDXListingID")]
        public int BDXListingID { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }
    }
}