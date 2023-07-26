using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "UserSessionEventLog")]
    public class UserSessionEventLog:PublicBaseEntity
    {
        [DataMember(Name = "UserID")]
        public int UserID { get; set; }
        [DataMember(Name = "LoginTime")]
        public DateTime LoginTime { get; set; }
        [DataMember(Name = "LogoutTime")]
        public DateTime LogoutTime { get; set; }
    }
}