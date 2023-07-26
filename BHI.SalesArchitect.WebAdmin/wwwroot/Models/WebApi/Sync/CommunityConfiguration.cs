using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="CommunityConfiguration")]
    public class CommunityConfiguration : BaseEntity
    {
        [DataMember(Name = "Value")]
        public string Value { get; set; }
        [DataMember(Name = "CommunityUD")]
        public int CommunityID { get; set; }
        [DataMember(Name = "ConfigurationID")]
        public int ConfigurationID { get; set; }
    }
}