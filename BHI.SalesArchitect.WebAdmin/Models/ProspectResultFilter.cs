using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    [Serializable]
    public class ProspectResultFilter
    {
        public string Ids { get; set; }
        public string Community { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string SortOrder { get; set; }
        public string SortName { get; set; }
        public bool IsAll { get; set; }
        public string ExcludeIds { get; set; }
        public bool IsAllChecked { get; set; }

    }
}