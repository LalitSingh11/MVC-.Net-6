using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="BuilderBrandListing")]
    public class BuilderBrandListing : BaseEntity
    {
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "BuilderBrandID")]
        public int BuilderBrandID { get; set; }
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
    }
}