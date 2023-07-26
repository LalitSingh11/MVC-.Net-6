using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="Name")]
    public class Partner : BDXEntity
    {
        [DataMember(Name ="Name")]
        public string Name { get; set; }
        [DataMember(Name = "DataKey")]
        public string DataKey { get; set; }

    }
}