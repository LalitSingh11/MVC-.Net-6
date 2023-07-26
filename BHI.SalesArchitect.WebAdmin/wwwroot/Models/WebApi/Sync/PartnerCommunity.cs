using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="PartnerCommunity")]
    public class PartnerCommunity : BaseEntity
    {
        [DataMember(Name ="PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
    }
}