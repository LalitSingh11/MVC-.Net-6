using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    [Serializable]
    public class BatchLot
    {
        public BatchLot()
        {
            Listings = new List<int>();
            LotIDs = new List<int>();
            DetailListings = new List<Listing>();
            DeletedListings = new List<int>();
        }

        public List<int> LotIDs { get; set; }
        public string Size { get; set; }
        public string Block { get; set; }
        public string Phase { get; set; }
        public int CommunityID { get; set; }
        public LotState LotState { get; set; }
        public List<int> Listings { get; set; }
        public string Elevation { get; set; }
        public string Swing { get; set; }
        public bool isAmenity { get; set; }
        public int? PremiumPrice { get; set; }
        public decimal ReservationFee { get; set; }
        public string ContactLink { get; set; }
        public string ButtonText { get; set; }
        public List<Listing> DetailListings { get; set; }
        public List<int> DeletedListings { get; set; }
    }
}