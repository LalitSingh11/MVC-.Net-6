using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="Action")]
    public class Action : BaseEntity
    {
        [DataMember(Name="Code")]
        public string Code { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}