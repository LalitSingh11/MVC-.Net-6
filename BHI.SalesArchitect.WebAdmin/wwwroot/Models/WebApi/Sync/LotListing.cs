using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="LotListing")]
    public class LotListing : BaseEntity
    {
        [DataMember(Name = "LotID")]
        public int LotID { get; set; }
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "Price")]
        public decimal Price { get; set; }
        [DataMember(Name = "ElevationImageID")]
        public int ListingImagesID { get; set; }
    }
}