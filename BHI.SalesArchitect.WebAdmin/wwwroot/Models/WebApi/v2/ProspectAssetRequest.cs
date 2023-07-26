using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "ProspectAssetRequest")]
    public class ProspectAssetRequest
    {
        [DataMember(Name ="ProspectAsset")]
        /// <summary>
        /// 
        /// </summary>
        public ProspectAsset ProspectAsset { get; set; }
        [DataMember(Name = "Listing")]
        /// <summary>
        /// 
        /// </summary>
        public Listing Listing { get; set; }
        [DataMember(Name = "CDPEvent")]
        public string CDPEvent { get; set; }

    }
}