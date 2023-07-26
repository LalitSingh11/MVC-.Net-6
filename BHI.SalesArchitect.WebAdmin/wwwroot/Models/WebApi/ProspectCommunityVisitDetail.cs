using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ProspectCommunityVisitDetail")]
    public class ProspectCommunityVisitDetail : BaseEntity
    {

        public ProspectCommunityVisitDetail()
        {

        }
        [DataMember(Name = "ProspectCommunityId")]
        public int ProspectCommunityId { get; set; }
        [DataMember(Name = "VisitDate")]
        public DateTime VisitDate { get; set; }
        [DataMember(Name = "CreatedOn")]
        public DateTime? CreatedOn { get; set; }
    }
}