using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "Listing")]
    public class Listing : BDXEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
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
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "VendorReference")]
        public string VendorReference { get; set; }
        [DataMember(Name = "HasIFP")]
        public bool HasIFP { get; set; }
        [DataMember(Name = "HasEnvisionURL")]
        public bool HasEnvisionURL { get; set; }
        [DataMember(Name = "BuilderListingURL")]
        public string BuilderListingURL { get; set; }
    }
}