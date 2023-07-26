using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "FilterOption")]
    public class FilterOption
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Value")]
        public string Value { get; set; }
        [DataMember(Name = "isSelected")]
        public bool isSelected { get; set; }
        [DataMember(Name = "Count")]
        public int Count { get; set; }
        [DataMember(Name = "LogoURL")]
        public string LogoURL { get; set; }

    }
}