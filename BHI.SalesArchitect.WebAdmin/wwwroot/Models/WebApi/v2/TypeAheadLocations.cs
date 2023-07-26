using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "TypeAheadLocations")]
    public class TypeAheadLocations
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Type")]
        public string Type { get; set; }
        [DataMember(Name = "MarketId")]
        public int MarketId { get; set; }
        [DataMember(Name = "MarketName")]
        public string MarketName { get; set; }
        [DataMember(Name = "MarketStateAbbr")]
        public string MarketStateAbbr { get; set; }
        [DataMember(Name = "MarketStateName")]
        public string MarketStateName { get; set; }
        [DataMember(Name = "Latitude")]
        public decimal? Latitude { get; set; }
        [DataMember(Name = "Longitude")]
        public decimal? Longitude { get; set; }
        [DataMember(Name = "City")]
        public string City { get; set; }
        [DataMember(Name = "State")]
        public string State { get; set; }
    }
}