using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="Site")]
    public class Site : BaseEntity
    {
        [DataMember(Name ="Name")]
        public string Name { get; set; }
        [DataMember(Name = "MapData")]
        public string MapData { get; set; }
        [DataMember(Name = "Version")]
        public string Version { get; set; }
        [DataMember(Name = "BuilderBDXID")]
        public int BuilderBDXID { get; set; }
    }
}