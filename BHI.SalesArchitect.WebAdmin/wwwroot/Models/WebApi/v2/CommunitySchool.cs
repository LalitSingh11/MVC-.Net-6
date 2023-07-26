using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunitySchool")]
    public class CommunitySchool : BaseEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "DistrictName")]
        public string DistrictName { get; set; }
    }
}