using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    public class RegisterCountForReport
    {
        [DataMember(Name ="MonthOrDate")]
        public String Month { get; set; }
        public int ProspectsCount { get; set; }
        public int ConsumersCount { get; set; }
    }
}