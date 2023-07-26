using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "AugmentedRealityHomeViewer")]
    public class AugmentedRealityHomeViewer
    {
        [DataMember(Name = "IOSUrl")]
        public string IOSUrl { get; set; }
        [DataMember(Name = "AndroidUrl")]
        public string AndroidUrl { get; set; }
    }
}