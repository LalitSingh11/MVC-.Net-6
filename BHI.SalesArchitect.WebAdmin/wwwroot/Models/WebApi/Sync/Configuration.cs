using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="Configuration")]
    public class Configuration : BaseEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Code")]
        public string Code { get; set; }
        [DataMember(Name = "AssetTypeID")]
        public int AssetTypeID { get; set; }
        [DataMember(Name="ConfigValue")]
        public string ConfigValue { get; set; }
    }
}