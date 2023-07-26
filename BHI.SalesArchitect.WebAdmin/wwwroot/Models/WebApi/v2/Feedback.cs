using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "Feedback")]
    public class Feedback:PublicBaseEntity
    {
        public int ConsumerID { get; set; }
        [DataMember(Name = "FeedbackCategoryID")]
        public int FeedbackCategoryID { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        [DataMember(Name = "Platform")]
        public int Platform { get; set; }
        public int PartnerID { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Email")]
        public string Email { get; set; }
        [DataMember(Name = "AppVersion")]
        public string AppVersion { get; set; }
    }
}