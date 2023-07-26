using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "Markets")]
    public class Markets : BaseEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "StateName")]
        public string StateName { get; set; }
        [DataMember(Name = "StateAbbreviation")]
        public string StateAbbreviation { get; set; }
        [DataMember(Name = "BrandId")]
        public int? BrandId { get; set; }

    }
}