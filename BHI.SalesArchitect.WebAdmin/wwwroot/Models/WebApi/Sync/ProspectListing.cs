using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "ProspectListing")]
    public class ProspectListing : BDXEntity
    {
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "ListingName")]
        public string ListingName { get; set; }
    }
}