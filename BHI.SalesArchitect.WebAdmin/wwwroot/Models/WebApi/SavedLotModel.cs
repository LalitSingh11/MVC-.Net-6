using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    public class SavedLotModel
    {
        public SavedLotv2 SavedLot { get; set; }
        public int BDXCommunityId { get; set; }
        public UUPUserLot UUPUserLot { get; set; }
        public CustomizedMessaging CustomizedMessaging { get; set; }
        public GADetails GADetails { get; set; }
    }
}