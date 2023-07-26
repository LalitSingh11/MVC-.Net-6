using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "PointOfInterest")]
    public class PointOfInterest : BaseEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}