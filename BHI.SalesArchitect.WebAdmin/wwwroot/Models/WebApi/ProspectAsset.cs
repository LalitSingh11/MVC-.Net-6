using System;
using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name ="ProspectAsset")]
    public class ProspectAsset : BaseEntity
    {
        [DataMember(Name ="ProspectID")]
        public int ProspectID { get; set; }
        [DataMember(Name = "AssetTypeID")]
        public int AssetTypeID { get; set; }
        [DataMember(Name = "ListingID")]
        public int? ListingID { get; set; }
        [DataMember(Name = "Value")]
        public string Value { get; set; }
        [DataMember(Name = "UploadData")]
        public string UploadData { get; set; }
        [DataMember(Name = "CreatedTime")]
        public DateTime CreatedTime { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }
        [DataMember(Name = "CommunityID")]
        public int? CommunityID { get; set; }
    }
}