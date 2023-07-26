using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="ListingInteractiveMedia")]
    public class ListingInteractiveMedia : BaseInteractiveMedia
    {
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "BDXListingID")]
        public int BDXListingID { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }
    }
}