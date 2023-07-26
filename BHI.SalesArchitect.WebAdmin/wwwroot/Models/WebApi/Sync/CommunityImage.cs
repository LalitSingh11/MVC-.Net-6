using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="CommunityImage")]
    public class CommunityImage : BaseImage
    {
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }
    }
}