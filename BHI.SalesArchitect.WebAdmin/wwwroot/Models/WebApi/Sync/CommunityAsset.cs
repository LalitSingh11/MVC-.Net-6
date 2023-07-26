using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="CommunityAsset")]
    public class CommunityAsset : BaseEntity
    {
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "Value")]
        public string Value { get; set; }
        [DataMember(Name = "Sequence")]
        public int Sequence { get; set; }
        [DataMember(Name = "AssetType")]
        public AssetType AssetType { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "Title")]
        public string Title { get; set; }

    }
}