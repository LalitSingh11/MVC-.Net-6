using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "POIPackage")]
    public class POIPackage : BasePackage
    {
        [DataMember(Name = "Points")]
       public List<NearByPointsOfInterest> Points { get; set; }
    }
}