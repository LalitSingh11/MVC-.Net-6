using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BHI.SalesArchitect.Core.Enumerations;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="PartnerSettings")]
    public class PartnerSettings
    {
        [DataMember(Name = "IsZipCodeRequired")]
        public bool IsZipCodeRequired { get; set; }
        [DataMember(Name = "MapProvider")]
        public MappingProvider  MapProvider { get; set; }
        [DataMember(Name = "HasCustomPOI")]
        public bool HasCustomPOI { get; set; }
        [DataMember(Name = "Name")]
        public String Name { get; set; }
        [DataMember(Name = "TrackingID")]
        public string TrackingID { get; set; }
        public PartnerSettings()
        {
            IsZipCodeRequired = false;
            HasCustomPOI = false;
            MapProvider = MappingProvider.MK;
        }
    }
}