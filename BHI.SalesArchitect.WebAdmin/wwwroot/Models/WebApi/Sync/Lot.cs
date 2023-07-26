using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="Lot")]
    public class Lot : BaseEntity
    {
        [DataMember(Name = "InternalReference")]
        public string InternalReference { get; set; }
        [DataMember(Name = "ExternalReference")]
        public string ExternalReference { get; set; }
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
        [DataMember(Name = "SiteID")]
        public int SiteID { get; set; }
        [DataMember(Name = "PremiumPrice")]
        public int? PremiumPrice { get; set; }
        [DataMember(Name = "LotStateID")]
        public int LotStateID { get; set; }
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
    }
}