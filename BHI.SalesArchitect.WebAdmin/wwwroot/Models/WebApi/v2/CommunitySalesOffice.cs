using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunitySalesOffice")]
    public class CommunitySalesOffice
    {
        [DataMember(Name = "SalesOffAddr")]
        public string SalesOffAddr { get; set; }
        [DataMember(Name = "SalesOffAddr2")]
        public string SalesOffAddr2 { get; set; }
        [DataMember(Name = "SalesOffCity")]
        public string SalesOffCity { get; set; }
        [DataMember(Name = "SalesOffZipCode")]
        public string SalesOffZipCode { get; set; }
        [DataMember(Name = "SalesOffState")]
        public string SalesOffState { get; set; }
        [DataMember(Name = "SalesOffEmail")]
        public string SalesOffEmail { get; set; }
        [DataMember(Name = "Hours")]
        public string Hours { get; set; }

    }
}