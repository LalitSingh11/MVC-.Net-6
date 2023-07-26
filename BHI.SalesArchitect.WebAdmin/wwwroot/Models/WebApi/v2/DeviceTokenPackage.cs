using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "DeviceTokenPackage")]
    public class DeviceTokenPackage
    {
        [DataMember(Name = "ConsumerID")]
        public int ConsumerID { get; set; }

        [DataMember(Name = "OldDeviceToken")]
        public string OldDeviceToken { get; set; }

        [DataMember(Name = "NewDeviceToken")]
        public string NewDeviceToken { get; set; }
        [DataMember(Name = "Platform")]
        public int Platform { get; set; }
        [DataMember(Name = "AppVersion")]
        public string AppVersion { get; set; }
    }
}