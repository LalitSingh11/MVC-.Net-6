using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="CommunityBuilderBrand")]
    public class CommunityBuilderBrand : BaseEntity
    {
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "BuilderBrandID")]
        public int BuilderBrandID { get; set; }
    }
}