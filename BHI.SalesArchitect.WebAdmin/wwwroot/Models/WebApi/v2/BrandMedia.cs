using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Api = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "BrandMedia")]
    public class BrandMedia
    {
        [DataMember(Name = "Images")]
        public List<Api.CommunityImage> Images { get; set; }
    }
}