using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="CommunitySite")]
    public class CommunitySite : BaseEntity
    {
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "SiteID")]
        public int SiteID { get; set; }
        [DataMember(Name = "MapImage")]
        public string MapImage { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }
        [DataMember(Name = "Version")]
        public string Version { get; set; }
    }
}