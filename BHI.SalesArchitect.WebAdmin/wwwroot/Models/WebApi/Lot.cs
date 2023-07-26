using BHI.SalesArchitect.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "Lot")]
    public class Lot : PublicBaseEntity
    {
        [DataMember(Name = "SiteID")]
        public int SiteID { get; set; }
        [DataMember(Name = "ExternalReference")]
        public string ExternalReference { get; set; }
        [DataMember(Name = "InternalReference")]
        public string InternalReference { get; set; }
        [DataMember(Name = "Size")]
        public string Size { get; set; }
        [DataMember(Name = "Block")]
        public string Block { get; set; }
        [DataMember(Name = "Phase")]
        public string Phase { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "Elevation")]
        public string Elevation { get; set; }
        [DataMember(Name = "Swing")]
        public string Swing { get; set; }
        [DataMember(Name = "LotStateID")]
        public int LotStateID { get; set; }
        [DataMember(Name = "PremiumPrice")]
        public int? PremiumPrice { get; set; }
        [DataMember(Name = "ListingIDs")]
        public List<int> ListingIDs { get; set; }
    }

    [DataContract(Name = "Lotv2")]
    public class Lotv2 : PublicBaseEntity
    {
        [DataMember(Name = "SiteID")]
        public int SiteID { get; set; }
        [DataMember(Name = "ExternalReference")]
        public string ExternalReference { get; set; }
        [DataMember(Name = "InternalReference")]
        public string InternalReference { get; set; }
        [DataMember(Name = "Size")]
        public string Size { get; set; }
        [DataMember(Name = "Block")]
        public string Block { get; set; }
        [DataMember(Name = "Phase")]
        public string Phase { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "Elevation")]
        public string Elevation { get; set; }
        [DataMember(Name = "Swing")]
        public string Swing { get; set; }
        [DataMember(Name = "LotStateID")]
        public int LotStateID { get; set; }
        [DataMember(Name = "PremiumPrice")]
        public int? PremiumPrice { get; set; }
        [DataMember(Name = "ListingsAndPrices")]
        public List<ListingPrices> ListingsAndPrices { get; set; }
        [DataMember(Name = "isAmenity")]
        public bool? isAmenity { get; set; }
        [DataMember(Name = "ContactLink")]
        public string ContactLink { get; set; }
        [DataMember(Name = "ImagePath")]
        public string ImagePath { get; set; }
        [DataMember(Name = "LotDescription")]
        public string LotDescription { get; set; }
        [DataMember(Name = "ButtonText")]
        public string ButtonText { get; set; }
        [DataMember(Name = "DisplayName")]
        public string DisplayName { get; set; }
        [DataMember(Name = "Color")]
        public string Color { get; set; }
        [DataMember(Name = "VideoURL")]
        public string VideoURL { get; set; }
        [DataMember(Name = "LotStateName")]
        public string LotStateName { get; set; }
        [DataMember(Name = "ReservationFee")]
        public decimal ReservationFee { get; set; }
        [DataMember(Name = "UpdateReservationPending")]
        public bool UpdateReservationPending { get; set; }
    }

    [DataContract(Name = "LotReservationRequest")]
    public class LotReservationRequest
    {
        [DataMember(Name = "bdxCommunityID")]
        public int bdxCommunityID { get; set; }
        [DataMember(Name = "bdxPartnerID")]
        public int bdxPartnerID { get; set; }
        [DataMember(Name = "lotID")]
        public int lotID { get; set; }
        [DataMember(Name = "paymentID")]
        public string paymentID { get; set; }
    }

    [DataContract(Name = "Lotv2")]
    public class SavedLotv2 : PublicBaseEntity
    {
        [DataMember(Name = "SiteID")]
        public int SiteID { get; set; }
        [DataMember(Name = "ExternalReference")]
        public string ExternalReference { get; set; }
        [DataMember(Name = "InternalReference")]
        public string InternalReference { get; set; }
        [DataMember(Name = "Size")]
        public string Size { get; set; }
        [DataMember(Name = "Block")]
        public string Block { get; set; }
        [DataMember(Name = "Phase")]
        public string Phase { get; set; }
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "Elevation")]
        public string Elevation { get; set; }
        [DataMember(Name = "Swing")]
        public string Swing { get; set; }
        [DataMember(Name = "LotStateID")]
        public int LotStateID { get; set; }
        [DataMember(Name = "PremiumPrice")]
        public int? PremiumPrice { get; set; }
        [DataMember(Name = "ListingsAndPrices")]
        public List<ListingPrices> ListingsAndPrices { get; set; }
        [DataMember(Name = "Listings")]
        public List<SiteOverviewListing> Listings { get; set; }
        [DataMember(Name = "isAmenity")]
        public bool isAmenity { get; set; }
        [DataMember(Name = "ContactLink")]
        public string ContactLink { get; set; }
        [DataMember(Name = "ImagePath")]
        public string ImagePath { get; set; }
        [DataMember(Name = "LotDescription")]
        public string LotDescription { get; set; }
        [DataMember(Name = "ButtonText")]
        public string ButtonText { get; set; }
        [DataMember(Name = "DisplayName")]
        public string DisplayName { get; set; }
        [DataMember(Name = "Color")]
        public string Color { get; set; }
        [DataMember(Name = "VideoURL")]
        public string VideoURL { get; set; }
        [DataMember(Name = "LotStateName")]
        public string LotStateName { get; set; }
        [DataMember(Name = "HoldALotEnabled")]
        public bool holdALotEnabled { get; set; }
        [DataMember(Name = "BuilderDescription")]
        public string BuilderDescription { get; set; }
        [DataMember(Name = "HoldALotHeaderText")]
        public string HoldALotHeaderText { get; set; }
        [DataMember(Name = "ISPPopupHomesite")]
        public string ISPPopupHomesite { get; set; }
        [DataMember(Name = "HoldALotButtonText")]
        public string HoldALotButtonText { get; set; }
        [DataMember(Name = "HoldALot")]
        public bool HoldALot { get; set; }
        [DataMember(Name = "LotPremiumOptionalDisplay")]
        public bool LotPremiumOptionalDisplay { get; set; }
        [DataMember(Name = "Reserved")]
        public bool Reserved { get; set; }
        [DataMember(Name = "ReservationPending")]
        public bool ReservationPending { get; set; }
        [DataMember(Name = "ReservationFee")]
        public decimal ReservationFee { get; set; }
        [DataMember(Name = "ReservationPendingDetail")]
        public ReservationPending ReservationPendingDetail { get; set; }
        [DataMember(Name = "HoldALotAccount")]
        public int HoldALotAccount { get; set; }
    }
}