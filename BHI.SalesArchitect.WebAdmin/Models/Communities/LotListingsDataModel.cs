using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.WebAdmin.Models.Communities
{
    public class LotListingsDataModel
    {
        public Lot lot { get; set; }
        public List<LotListing> lotListing { get; set; }
    }
}
