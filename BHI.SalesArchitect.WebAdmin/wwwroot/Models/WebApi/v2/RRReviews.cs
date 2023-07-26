using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "RRReviews")]
    public class RRReviews
    {
        [DataMember(Name = "Content")]
        public string Content { get; set; }
        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "GeneralRating")]
        public int GeneralRating { get; set; }
        [DataMember(Name = "IsAnonymous")]
        public bool IsAnonymous { get; set; }
        [DataMember(Name = "LastName")]
        public string LastName { get; set; }
        [DataMember(Name = "MarketId")]
        public int? MarketId { get; set; }
        [DataMember(Name = "MarketName")]
        public string MarketName { get; set; }
        [DataMember(Name = "StateAbbr")]
        public string StateAbbr { get; set; }
        [DataMember(Name = "Title")]
        public string Title { get; set; }
        [DataMember(Name = "IsPrimaryBuyer")]
        public bool IsPrimaryBuyer { get; set; }
    }
}