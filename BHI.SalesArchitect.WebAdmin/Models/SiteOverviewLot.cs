using System.Collections.Generic;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class SiteOverviewLot
    {
        public int id { get; set; }
        public string internalReference { get; set; }
        public string externalReference { get; set; }
        public string size { get; set; }
        public string block { get; set; }
        public string phase { get; set; }
        public string elevation { get; set; }
        public string swing { get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public string color { get; set; }
        public string lotStateName { get; set; }
        public string imagePath { get; set; }
        public string contactLink { get; set; }
        public string lotDescription { get; set; }
        public string buttonText { get; set; }
        public int? premiumPrice { get; set; }
        public List<SiteOverviewListing> listings { get; set; }
        public bool isAmenity { get; set; }
        public string displayName { get; set; }
        public string videoURL { get; set; }
        public string holdALotButtonText { get; set; }
        public bool holdALotEnabled { get; set; }
        public bool IncludeDWStatus { get; set; }
        public int communityId { get; set; }
        public int SiteID { get; set; }
        public List<CallToAction> CTAs { get; set; }
        public decimal ReservationFee { get; set; }
        public bool Reserved { get; set; }
        public bool ReservationPending { get; set; }
        public int internalCommunityId { get; set; }
    }
}