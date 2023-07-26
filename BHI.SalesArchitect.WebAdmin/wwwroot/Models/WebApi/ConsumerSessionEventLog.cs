using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ConsumerSessionEventLog")]
    public class ConsumerSessionEventLog :PublicBaseEntity
    {
        [DataMember(Name = "ConsumerID")]
        public int ConsumerID { get; set; }
        [DataMember(Name = "LoginTime")]
        public DateTime LoginTime { get; set; }
        [DataMember(Name = "LogoutTime")]
        public DateTime LogoutTime { get; set; }
    }
}