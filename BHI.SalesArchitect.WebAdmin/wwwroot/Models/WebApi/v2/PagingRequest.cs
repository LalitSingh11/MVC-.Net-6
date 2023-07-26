using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    public class PagingRequest
    {
        public int PageSize { get; set; }
        public int page { get; set; }
        public string SortBy { get; set; }
        public string SortSecondBy { get; set; }
        public string SortFirstBy { get; set; }
        public bool SortOrder { get; set; }
        public bool SortSecondOrder { get; set; }
    }
}