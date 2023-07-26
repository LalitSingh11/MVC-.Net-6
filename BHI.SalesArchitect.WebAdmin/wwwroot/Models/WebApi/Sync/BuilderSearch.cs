using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "BuilderSearch")]
    public class BuilderSearch
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "BuilderLogo")]
        public string BuilderLogo { get; set; }
        [DataMember(Name = "BuilderLogoSmall")]
        public string BuilderLogoSmall { get; set; }
        [DataMember(Name = "BuilderId")]
        public int BuilderId { get; set; }
        [DataMember(Name = "Count")]
        public int Count { get; set; }
        [DataMember(Name = "BrandId")]
        public int BrandId { get; set; }
    }
}