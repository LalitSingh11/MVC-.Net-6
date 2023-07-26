using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "NearByPointsOfInterest")]
    public class NearByPointsOfInterest : BaseEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "City")]
        public string City { get; set; }
        [DataMember(Name = "State")]
        public string State { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [DataMember(Name = "Latitude")]
        public double Latitude { get; set; }
        [DataMember(Name = "Longitude")]
        public double Longitude { get; set; }
        [DataMember(Name = "PointOfInterestID")]
        public int PointOfInterestID { get; set; }
        [DataMember(Name = "Distance")]
        public double Distance { get; set; }
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }

    }
}