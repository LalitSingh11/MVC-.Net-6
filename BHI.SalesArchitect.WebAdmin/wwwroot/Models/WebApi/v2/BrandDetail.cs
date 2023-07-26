using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using ApiSync = BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "BrandDetail")]
    public class BrandDetail
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Logo")]
        public string Logo { get; set; }
        [DataMember(Name = "LogoSmall")]
        public string LogoSmall { get; set; }
        [DataMember(Name = "BrandUrl")]
        public string BrandUrl { get; set; }
        [DataMember(Name = "Overview")]
        public string Overview { get; set; }
        [DataMember(Name = "About")]
        public string About { get; set; }
        [DataMember(Name = "BrandImages")]
        public List<ApiSync.CommunityImage> BrandImages { get; set; }
        [DataMember(Name = "SiteUrl")]
        public string SiteUrl { get; set; }
        [DataMember(Name = "BrandLocations")]
        public List<ApiSync.Market> BrandLocations { get; set; }
        [DataMember(Name = "SortingList")]
        public List<FilterOption> SortingList { get; set; }
        [DataMember(Name = "AreaList")]
        public List<RRMarketLocation> AreaList { get; set; }
    }
}