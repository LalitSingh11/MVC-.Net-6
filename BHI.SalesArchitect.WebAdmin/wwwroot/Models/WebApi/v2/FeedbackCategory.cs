using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "FeedbackCategory")]
    public class FeedbackCategory : BaseEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}