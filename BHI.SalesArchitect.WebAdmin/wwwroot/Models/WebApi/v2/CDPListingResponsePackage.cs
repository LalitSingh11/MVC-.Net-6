using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using ApiSync = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "CDPListingResponsePackage")]
    public class CDPListingResponsePackage
    {
        [DataMember(Name = "Listing")]
        public Listing Listing { get; set; }
        [DataMember(Name = "ProspectListing")]
        public ApiSync.ProspectListing ProspectListing { get; set; }

    }
}