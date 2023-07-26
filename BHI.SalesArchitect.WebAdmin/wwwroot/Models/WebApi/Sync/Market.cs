using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{

    [DataContract(Name ="Market")]
    public class Market : BDXEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}