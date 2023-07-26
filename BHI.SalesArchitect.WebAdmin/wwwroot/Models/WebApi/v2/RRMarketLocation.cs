using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "RRMarketLocation")]
    public class RRMarketLocation
    {
        [DataMember(Name = "AverageGeneralRatingValueRounded")]
        public float? AverageGeneralRatingValueRounded { get; set; }
        [DataMember(Name = "ReviewsCount")]
        public int ReviewsCount { get; set; }
        [DataMember(Name = "MarketId")]
        public int MarketId { get; set; }
        [DataMember(Name = "MarketName")]
        public string MarketName { get; set; }
        [DataMember(Name = "StateAbbr")]
        public string StateAbbr { get; set; }
    }
}