using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "SiteMapPackage")]
    public class SiteMapPackage : BasePackage
    {
        [DataMember(Name ="Data")]
        public Site Data { get; set; }
    }
    public class SiteMapPackage<T> : SiteMapPackage
    {
        [DataMember(Name = "Model")]
        public T Model { get; set; }
    }
}