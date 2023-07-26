using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "CommunityFavoriteModal")]
    public class CommunityFavoriteRequestModal
    {
        [DataMember(Name = "CommunityId")]
        public int CommunityId { get; set; }
        [DataMember(Name = "ConsumerId")]
        public int ConsumerId { get; set; }
        [DataMember(Name = "IsFavorite")]
        public bool IsFavorite { get; set; }
    }
}