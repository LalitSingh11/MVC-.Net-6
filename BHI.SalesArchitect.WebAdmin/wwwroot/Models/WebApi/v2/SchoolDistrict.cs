using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "SchoolDistrict")]
    public class SchoolDistrict
	{
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Schools")]
        public List<CommunitySchool> Schools { get; set; }
    }
}