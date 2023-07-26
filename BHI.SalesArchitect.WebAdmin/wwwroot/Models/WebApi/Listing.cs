using System.Runtime.Serialization;
using System.Web.Mvc;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name ="Listing")]
    public class Listing : PublicBaseEntity
    {
        [DataMember(Name = "BDXID")]
        public int BDXID { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }
        [DataMember(Name ="Name")]
        public string Name { get; set; }
        [DataMember(Name= "PlanImage")]
        public string PlanImage { get; set; }
        [DataMember(Name = "Type")]
        public string Type { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "City")]
        public string City { get; set; }
        [DataMember(Name = "State")]
        public string State { get; set; }
        [DataMember(Name = "Zip")]
        public string Zip { get; set; }
        [DataMember(Name = "BasePrice")]
        public decimal? BasePrice { get; set; }
        [DataMember(Name = "Bedrooms")]
        public int? Bedrooms { get; set; }
        [DataMember(Name = "Baths")]
        public decimal? Baths { get; set; }
        [DataMember(Name = "BaseSquareFeet")]
        public int? BaseSquareFeet { get; set; }
        [DataMember(Name = "Garage")]
        public decimal? Garage { get; set; }
        [DataMember(Name = "Stories")]
        public int? Stories { get; set; }
        [DataMember(Name = "MasterBedLocation")]
        public string MasterBedLocation { get; set; }
        [DataMember(Name = "VirtualTour")]
        public string VirtualTour { get; set; }
        [DataMember(Name = "PlanType")]
        public string PlanType { get; set; }
        [DataMember(Name = "LivingAreas")]
        public int? LivingAreas { get; set; }
        [DataMember(Name = "DiningAreas")]
        public int? DiningAreas { get; set; }
        [DataMember(Name = "Basement")]
        public bool? Basement { get; set; }
        [DataMember(Name = "EnvisionDesignCenter")]
        public string EnvisionDesignCenter { get; set; }
        [DataMember(Name = "Description"),AllowHtml]
        public string Description { get; set; }
        [DataMember(Name = "VendorReference")]
        public string VendorReference { get; set; }
        [DataMember(Name = "HasEnvisionURL")]
        public bool HasEnvisionURL { get; set; }
        [DataMember(Name = "SiteID")]
        public int SiteID { get; set; }
        [DataMember(Name = "CommunityVendorReference")]
        public string CommunityVendorReference { get; set; }
        [DataMember(Name = "BuilderListingURL")]
        public string BuilderListingURL { get; set; }
        [DataMember(Name = "Status")]
        public string Status { get; set; }
        [DataMember(Name = "HalfBath")]
        public decimal? HalfBath { get; set; }
        [DataMember(Name = "SelfGuidedTour")]
        public bool SelfGuidedTour { get; set; }
        [DataMember(Name = "BrandId")]
        public int BrandId { get; set; }
        [DataMember(Name = "ParentBDXCommunityID")]
        public int ParentBDXCommunityID { get; set; }
        [DataMember(Name = "BuilderBDXID")]
        public int BuilderBDXID { get; set; }
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }
        [DataMember(Name = "BrandName")]
        public string BrandName { get; set; }
        [DataMember(Name = "SuppressPrice")]
        public bool SuppressPrice { get; set; }

    }
}