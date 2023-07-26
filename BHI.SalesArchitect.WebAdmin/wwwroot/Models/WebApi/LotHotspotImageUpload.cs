using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "LotHotspotImageUpload")]
    public class LotHotspotImageUpload:PublicRequestPackage
    {
        [DataMember(Name = "HotSpotImageFile")]
        public HttpPostedFileBase HotSpotImageFile { get; set; }
        [DataMember(Name = "ID")]
        public int ID { get; set; }
    }
}