using System.Collections.Generic;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "Community")]
    public class Community : PublicBaseEntity
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "City")]
        public string City { get; set; }
        [DataMember(Name = "Zip")]
        public string Zip { get; set; }
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }
        [DataMember(Name = "VendorReference")]
        public string VendorReference { get; set; }
        [DataMember(Name = "Sites")]
        public List<CommunitySite> Sites { get; set; }
        [DataMember(Name = "BDXBuilderID")]
        public int BDXBuilderID { get; set; }
    }
}