using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="CommunityPointOfInterest")]
    public class CommunityPointOfInterest : BaseEntity
    {
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "PointOfInterestID")]
        public int PointOfInterestID { get; set; }
    }
}