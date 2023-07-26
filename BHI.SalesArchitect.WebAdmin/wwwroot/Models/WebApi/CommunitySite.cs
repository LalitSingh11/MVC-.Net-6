using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name ="CommunitySite")]
    public class CommunitySite : BaseEntity
    {
        [DataMember(Name ="Name")]
        public string Name { get; set; }
    }
}