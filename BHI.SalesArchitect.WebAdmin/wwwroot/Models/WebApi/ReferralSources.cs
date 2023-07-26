using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ReferralSources")]
    public class ReferralSources: BaseEntity
    {
        [DataMember(Name = "Title")]
        public string Title { get; set; }
        [DataMember(Name = "SubTitle")]
        public string SubTitle { get; set; }
        [DataMember(Name = "FieldType")]
        public int FieldType { get; set; }
        [DataMember(Name = "PlaceholderText")]
        public string PlaceholderText { get; set; }
    }
}