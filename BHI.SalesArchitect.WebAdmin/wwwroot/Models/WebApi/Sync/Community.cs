using System.Collections.Generic;
using BHI.SalesArchitect.Model;

using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "Community")]
    public class Community : BDXEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "City")]
        public string City { get; set; }
        [DataMember(Name = "State")]
        public string State { get; set; }
        [DataMember(Name = "Zip")]
        public string Zip { get; set; }
        [DataMember(Name = "BrandLogoMedium")]
        public string BrandLogoMedium { get; set; }
        [DataMember(Name = "BrandLogoSmall")]
        public string BrandLogoSmall { get; set; }
        [DataMember(Name = "Latitude")]
        public decimal Latitude { get; set; }
        [DataMember(Name = "Longitude")]
        public decimal Longitude { get; set; }
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }
        [DataMember(Name = "SubDescription")]
        public string SubDescription { get; set; }
        [DataMember(Name = "CustomDescription")]
        public string CustomDescription { get; set; }
        [DataMember(Name = "VenderReference")]
        public string VendorReference { get; set; }
        [DataMember(Name = "AdminList")]
        public List<string> AdminList { get; set; }
        [DataMember(Name = "MarketID")]
        public int MarketID { get; set; }
        [DataMember(Name = "MarketName")]
        public string MarketName { get; set; }
        [DataMember(Name = "ActivityStateID")]
        public int ActivityStateID { get; set; }
        [DataMember(Name = "MasterPlanID")]
        public int? MasterPlanID { get; set; }
        [DataMember(Name = "HasVideos")]
        public bool HasVideos { get; set; }
        [DataMember(Name = "minimumPrice")]
        public decimal minimumPrice { get; set; }
        [DataMember(Name = "maximumPrice")]
        public decimal maximumPrice { get; set; }
        [DataMember(Name = "IsFavorite")]
        public bool IsFavorite { get; set; }
        [DataMember(Name = "CommunityImage")]
        public string CommunityImage { get; set; }
        [DataMember(Name = "CurrentDBVersion")]
        public int CurrentDBVersion { get; set; }
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "PartnerName")]
        public string PartnerName { get; set; }
        [DataMember(Name = "EnvisionDesignCenter")]
        public string EnvisionDesignCenter { get; set; }
        [DataMember(Name = "Hours")]
        public string Hours { get; set; }
        [DataMember(Name = "PreferredCommunityAssetId")]
        public int PreferredCommunityAssetId { get; set; }
        [DataMember(Name = "SqftLow")]
        public string SqftLow { get; set; }
        [DataMember(Name = "SqftHigh")]
        public string SqftHigh { get; set; }
        [DataMember(Name = "BDXBuilderID")]
        public int BDXBuilderID { get; set; }
        [DataMember(Name = "BDXBrandId")]
        public int BDXBrandId { get; set; }
        [DataMember(Name = "homeCount")]
        public int homeCount { get; set; }
        [DataMember(Name = "CommunityStatus")]
        public string CommunityStatus { get; set; }
        [DataMember(Name = "HasGeoJSON")]
        public bool HasGeoJSON { get; set; }
        [DataMember(Name = "DisplayName")]
        public string DisplayName { get; set; }
        [DataMember(Name = "IsOverwriteName")]
        public bool IsOverwriteName { get; set; }
        [DataMember(Name = "ProjectType")]
        public string ProjectType { get; set; }
        [DataMember(Name = "BedLow")]
        public int BedLow { get; set; }
        [DataMember(Name = "BedHigh")]
        public int BedHigh { get; set; }
        [DataMember(Name = "HaBathLow")]
        public float HaBathLow { get; set; }
        [DataMember(Name = "HaBathHigh")]
        public float HaBathHigh { get; set; }
        [DataMember(Name = "BathLow")]
        public float BathLow { get; set; }
        [DataMember(Name = "BathHigh")]
        public float BathHigh { get; set; }
        [DataMember(Name = "GrLow")]
        public float? GrLow { get; set; }
        [DataMember(Name = "GrHigh")]
        public float? GrHi { get; set; }
        [DataMember(Name = "SuppressPrice")]
        public bool SuppressPrice { get; set; }
    }
    [DataContract(Name = "SearchCommunityResponse")]
    public class SearchCommunityResponse : Community
    {
        [DataMember(Name = "IsAlreadyAdded")]
        public bool IsAlreadyAdded { get; set; }
    }
}