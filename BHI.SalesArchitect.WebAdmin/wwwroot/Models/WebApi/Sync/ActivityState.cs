using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="ActivityState")]
    public class ActivityState : BaseEntity
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}