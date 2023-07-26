using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CommunitySalesAgent")]
    public class CommunitySalesAgent
    {
        [DataMember(Name = "Email")]
        public string Email { get; set; }
        [DataMember(Name = "Img")]
        public string Img { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Title")]
        public string Title { get; set; }
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }
        [DataMember(Name = "BuilderId")]
        public int BuilderId { get; set; }
    }
}