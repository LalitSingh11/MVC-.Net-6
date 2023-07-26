using BHI.SalesArchitect.Model;
using System;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name = "ProspectAsset")]
    public class ProspectAsset : BaseEntity
    {
        [DataMember(Name = "Value")]
        public string Value { get; set; }
        [DataMember(Name = "AssetTypeID")]
        public int AssetTypeID { get; set; }
        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "ListingID")]
        public int? ListingID { get; set; }
        [DataMember(Name = "CommunityID")]
        public int? CommunityID { get; set; }
        [DataMember(Name = "CreatedTime")]
        public DateTime CreatedTime { get; set; }
        [DataMember(Name = "BDXListingID")]
        public int? BDXListingID { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        public int BDXCommunityID { get; set; }
        [DataMember(Name = "ListingName")]
        public string ListingName { get; set; }
        [DataMember(Name = "isSpec")]
        public bool isSpec { get; set; }

    }
}