using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="BuilderBrand")]
    public class BuilderBrand : BDXEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}