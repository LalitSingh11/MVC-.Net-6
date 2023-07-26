using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using ApiSync = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    public class ProspectListingInsertPackage: InsertPackage
    {
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }

        [DataMember(Name = "Model")]
        public ApiSync.ProspectListing Model { get; set; }
    }
}