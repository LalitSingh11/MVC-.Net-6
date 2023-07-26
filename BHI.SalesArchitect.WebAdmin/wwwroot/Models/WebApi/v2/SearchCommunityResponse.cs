using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "SearchCommunityResponse")]
    public class SearchCommunityResponse : BDXEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}