using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name ="PartnerBuilderBrand")]
    public class PartnerBuilderBrand : BaseEntity
    {
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "BuilderBrandID")]
        public int BuilderBrandID { get; set; }
    }
}