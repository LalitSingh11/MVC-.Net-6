using System.Collections.Generic;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name ="LotPackage")]
    public class LotPackage : PublicBaseEntity
    {
        [DataMember(Name ="Lots")]
        public List<Lot> Lots { get; set; }
        [DataMember(Name = "LotListings")]
        public List<Sync.LotListing> LotListings { get; set; }
        [DataMember(Name = "LotStateConfigurations")]
        public List<Sync.LotStateConfiguration> LotStateConfigurations { get; set; }
    }

    [DataContract(Name = "LotPackagev2")]
    public class LotPackagev2 : PublicBaseEntity
    {
        [DataMember(Name = "Lots")]
        public List<Lotv2> Lots { get; set; }
        [DataMember(Name = "LotListings")]
        public List<Sync.LotListing> LotListings { get; set; }
        [DataMember(Name = "LotStateConfigurations")]
        public List<Sync.LotStateConfiguration> LotStateConfigurations { get; set; }
    }
}