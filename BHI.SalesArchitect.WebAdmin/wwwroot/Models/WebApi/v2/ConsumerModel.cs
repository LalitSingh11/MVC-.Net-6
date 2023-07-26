using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "ChangePassword")]
    public class ConsumerModel
    {
        [DataMember(Name = "Email")]
        public string Email { get; set; }
        [DataMember(Name = "Platform")]
        public int? Platform { get; set; }
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "CommunityID")]
        public int? CommunityID { get; set; }
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "PushNotificationDate")]
        public DateTime? PushNotificationDate { get; set; }
        [DataMember(Name = "NotificationCount")]
        public int? NotificationCount { get; set; }
        [DataMember(Name = "ConsumerID")]
        public int? ConsumerID { get; set; }
        [DataMember(Name = "ProspectCommunityID")]
        public int? ProspectCommunityID { get; set; }
        [DataMember(Name = "ProspectListingID")]
        public int? ProspectListingID { get; set; }
        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "Type")]
        public string Type { get; set; }
        [DataMember(Name = "PCommunityID")]
        public int? PCommunityID { get; set; }
        [DataMember(Name = "PListingID")]
        public int? PListingID { get; set; }
    }
}