using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Base
{
    public class ProspectCommunityBase : BaseEntity
    {
        /// <summary>
        /// Community ID
        /// </summary>
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        /// <summary>
        /// Notes to be shared by Sales Architect Builder
        /// </summary>
        [DataMember(Name = "SharedNotes")]
        public string SharedNotes { get; set; }
    }
}