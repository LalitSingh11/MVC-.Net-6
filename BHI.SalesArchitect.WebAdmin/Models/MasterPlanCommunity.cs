using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class MasterPlanCommunity
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int SiteID { get; set; }
        public bool NewIsp { get; set; }
        public int BDXID { get; set; }
    }
}