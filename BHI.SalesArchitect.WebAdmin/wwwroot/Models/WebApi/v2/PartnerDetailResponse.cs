using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using ApiSync = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;
using Repo = BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "PartnerDetail")]
    public class PartnerDetailResponse
    {
        [DataMember(Name ="Partner")]
        public List<ApiSync.Partner> Partner { get; set; }
        [DataMember(Name = "BuilderAppConfiguration")]
        public List<ApiSync.Configuration> BuilderAppConfiguration { get; set; }
    }
}