using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    public class CommunityVideoTour : BaseEntity
    {
        public int CommunityID { get; set; }
        public int PartnerID { get; set; }
        public string URL { get; set; }
    }
}