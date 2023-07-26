using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "Community")]
    public class GeoJsonAPI
    {
        [DataMember(Name = "Parcels")]
        public string Parcels { get; set; }
        [DataMember(Name = "APIKey")]
        public string APIKey { get; set; }
        [DataMember(Name = "ClientId")]
        public string ClientId { get; set; }
        [DataMember(Name = "ZoomLevel")]
        public int ZoomLevel { get; set; }
        [DataMember(Name = "SVGMapData")]
        public string SVGMapData { get; set; }
        [DataMember(Name = "GeospatialDefaultSatelliteView")]
        public bool GeospatialDefaultSatelliteView { get; set; }
    }
}