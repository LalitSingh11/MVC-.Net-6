using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunityAmenityCategory")]
    public class CommunityAmenityCategory
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Amenity")]
        public List<CommunityAmenities> Amenity { get; set; }
    }
}