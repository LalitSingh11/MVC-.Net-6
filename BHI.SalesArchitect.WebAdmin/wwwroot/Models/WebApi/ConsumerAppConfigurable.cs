using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ConsumerAppConfigurable")]
    public class ConsumerAppConfigurable : BaseEntity
    {
        [DataMember(Name = "DesignIntroText")]
        public string DesignIntroText { get; set; }
        [DataMember(Name = "DesignDoYouKnow")]
        public string DesignDoYouKnow { get; set; }
        [DataMember(Name = "PartnerId")]
        public int PartnerId { get; set; }
    }
}