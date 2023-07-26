using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "ProspectBuilder")]
    public class ProspectBuilder : BaseEntity
    {
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "AddedDate")]
        public DateTime AddedDate { get; set; }
        [DataMember(Name = "BdxBrandID")]
        public int BdxBrandID { get; set; }
        [DataMember(Name = "BrandName")]
        public string BrandName { get; set; }
        [DataMember(Name = "BrandLogo")]
        public string BrandLogo { get; set; }
        [DataMember(Name = "BrandCommunityCount")]
        public int BrandCommunityCount { get; set; }
        [DataMember(Name = "IncludeMPC")]
        public bool IncludeMPC { get; set; }
        [DataMember(Name = "AddSource")]
        public int AddSource { get; set; }
    }
}