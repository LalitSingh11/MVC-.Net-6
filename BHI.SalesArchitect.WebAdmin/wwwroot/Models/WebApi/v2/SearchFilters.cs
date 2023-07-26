using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "FacetsResponse")]
    public class SearchFilters
    {
        [DataMember(Name = "FilterTitle")]
        public string FilterTitle { get; set; }
        [DataMember(Name = "FilterValue")]
        public List<FilterOption> FilterValue { get; set; }
        [DataMember(Name = "isMultiSelect")]
        public bool isMultiSelect { get; set; }
        [DataMember(Name = "isSegment")]
        public bool isSegment { get; set; }
        [DataMember(Name = "isCheckbox")]
        public bool isCheckbox { get; set; }
        [DataMember(Name = "checkBoxText")]
        public string checkBoxText { get; set; }
        [DataMember(Name = "logoUrl")]
        public string logoUrl { get; set; }
    }
}