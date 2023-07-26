using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="InteractiveMedia")]
    public class InteractiveMedia : BaseInteractiveMedia
    {
        [DataMember(Name ="CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }
    }
}