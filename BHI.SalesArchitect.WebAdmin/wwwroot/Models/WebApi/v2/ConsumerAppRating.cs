using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "ConsumerAppRating")]
    public class ConsumerAppRating : PublicBaseEntity
    {
        [DataMember(Name = "ConsumerID")]
        public int ConsumerID { get; set; }
        [DataMember(Name = "Platform")]
        public int Platform { get; set; }
        [DataMember(Name = "AppVersion")]
        public string AppVersion { get; set; }
        [DataMember(Name = "RatingStatus")]
        public int RatingStatus { get; set; }
        [DataMember(Name = "Date")]
        public DateTime Date { get; set; }
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "isEligibleToRate")]
        public bool IsEligibleToRate { get; set; }
    }
}