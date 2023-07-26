using System;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="VersionPackage")]
    public class VersionPackage : BasePackage
    {
        [DataMember(Name ="Version")]
        public int Version { get; set; }
        [DataMember(Name = "LastUpdated")]
        public DateTime LastUpdated { get; set; }
    }
}