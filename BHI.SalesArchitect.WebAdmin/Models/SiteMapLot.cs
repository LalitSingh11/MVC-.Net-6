using System.Collections.Generic;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class SiteMapLot
    {
        public SiteMapLot()
        {
        }

        public string InternalReference { get; set; }
        public string ExternalReference { get; set; }
        public string Size { get; set; }
        public string Block { get; set; }
        public string Phase { get; set; }
        public string Elevation { get; set; }
        public string Swing { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Color { get; set; }
        public string LotStateName { get; set; }
        public int SiteID { get; set; }
        public int CommunityID { get; set; }
        public List<SiteMapListing> Listings { get; set; }
        public bool NewIsp { get; set; }
        public string ImagePath { get; set; }
        public string ContactLink { get; set; }
        public string LotDescription { get; set; }
        public string ButtonText { get; set; }
        public int? PremiumPrice { get; set; }
        public string Id { get; set; }
        public bool IsAmenity { get; set; }
        public string displayName { get; set; }
        public string VideoURL { get; set; }
        public bool holdALotEnabled { get; set; }
        public List<CallToAction> CTAs { get; set; }
    }
}