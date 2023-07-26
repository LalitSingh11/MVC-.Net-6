using System;
using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    public class ProspectCommunity : BaseEntity
    {
        public int ProspectID { get; set; }
        public int CommunityID { get; set; }
        public int UserID { get; set; }
        public DateTime LastDateOfVisit { get; set; }
        public int ActivityStateID { get; set; }
        public string SharedNotes { get; set; }
        public string PrivateNotes { get; set; }
        public bool IsFavorite { get; set; }
    }
}