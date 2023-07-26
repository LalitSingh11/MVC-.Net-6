using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ConsumerAppResource")]
    public class ConsumerAppResource : BaseEntity
    {
        [DataMember(Name = "Title")]
        public string Title { get; set; }
        [DataMember(Name = "ParentId")]
        public int? ParentId { get; set; }
        [DataMember(Name = "URL")]
        public string URL { get; set; }
        [DataMember(Name = "Sequence")]
        public int Sequence { get; set; }
        [DataMember(Name = "PartnerId")]
        public int PartnerId { get; set; }
        [DataMember(Name = "BuilderBrandID")]
        public int BuilderBrandID { get; set; }
        [DataMember(Name = "BuilderBrandBDXID")]
        public int BuilderBrandBDXID { get; set; }
        [DataMember(Name = "IsISP")]
        public bool IsISP { get; set; }

    }
}