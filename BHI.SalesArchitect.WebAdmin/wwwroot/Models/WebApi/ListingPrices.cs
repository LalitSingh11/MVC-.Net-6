using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ListingPrices")]
    public class ListingPrices : BDXEntity
    {
        [DataMember(Name = "ListingId")]
        public int ListingId { get; set; }
        [DataMember(Name = "PlanPlusLotPrice")]
        public decimal Price { get; set; }
        [DataMember(Name = "ElevationImageID")]
        public int ElevationImageID { get; set; }
    }
}