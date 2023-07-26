using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name ="PublicBaseEntity")]
    public class PublicBaseEntity : BaseEntity
    {
        [DataMember(Name ="Error")]
        public string Error { get; set; }
    }
}