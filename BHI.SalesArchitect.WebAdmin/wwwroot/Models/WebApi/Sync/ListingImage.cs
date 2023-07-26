using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="ListingImage")]
    public class ListingImage : BaseImage
    {
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "Category")]
        public string Category { get; set; }
        [DataMember(Name = "BDXListingID")]
        public int BDXListingID { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }
    }
}