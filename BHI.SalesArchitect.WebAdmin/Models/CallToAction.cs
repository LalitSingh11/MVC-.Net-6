using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class CallToAction
    {
        public int SiteId { get; set; }
        public int LotId { get; set; }
        public string ConfigType { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}