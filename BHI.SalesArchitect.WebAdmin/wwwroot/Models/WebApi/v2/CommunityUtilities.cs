using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunityUtilities")]
    public class CommunityUtilities
    {
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }
        [DataMember(Name = "TypeCode")]
        public string TypeCode { get; set; }
        [DataMember(Name = "TypeName")]
        public string TypeName { get; set; }
        [DataMember(Name = "MonthlyFee")]
        public float MonthlyFee { get; set; }
        [DataMember(Name = "YearlyFee")]
        public float YearlyFee { get; set; }

    }
}