using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    public class SalesUserGeneratedLeadsCount
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int ProspectsCount { get; set; }
        public int month { get; set; }
        public string date { get; set; }
    }
}