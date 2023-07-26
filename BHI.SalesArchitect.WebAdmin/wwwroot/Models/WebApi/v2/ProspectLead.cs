using BHI.SalesArchitect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    public class ProspectLead : BaseEntity
    {
        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "LastName")]
        public string LastName { get; set; }
        [DataMember(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [DataMember(Name = "ZipCode")]
        public string ZipCode { get; set; }
        [DataMember(Name = "Listings")]
        public List<string> Listings { get; set; }
        [DataMember(Name = "Comments")]
        public string Comments { get; set; }
        [DataMember(Name = "DateOfVisit")]
        public DateTime DateOfVisit { get; set; }
        [DataMember(Name = "CommunityID")]
        public int CommunityID { get; set; }
        [DataMember(Name = "BuilderID")]
        public int BuilderID { get; set; }
        [DataMember(Name = "EmailAddress")]
        public string EmailAddress { get; set; }
        [DataMember(Name = "Response")]
        public string Response { get; set; }
        public string ActionOwner { get; set; }
        [DataMember(Name = "PartnerID")]
        public int PartnerID { get; set; }
        [DataMember(Name = "IsAPILead")]
        public bool IsAPILead { get; set; }
        [DataMember(Name = "LeadAction")]
        public string LeadAction { get; set; }
        [DataMember(Name = "LeadType")]
        public string LeadType { get; set; }
        [DataMember(Name = "PlanId")]
        public int PlanId { get; set; }
        [DataMember(Name = "SpecId")]
        public int SpecId { get; set; }
        public string LeadPostingPassword { get; set; }
        [DataMember(Name = "Platform")]
        public int Platform { get; set; }
        [DataMember(Name = "AppointmentDate")]
        public string AppointmentDate { get; set; }
        [DataMember(Name = "NumberOfRecommendations")]
        public int NumberOfRecommendations { get; set; }
        [DataMember(Name = "ProspectId")]
        public int? ProspectId { get; set; }
        [DataMember(Name = "HoldaLot")]
        public bool HoldaLot { get; set; }
        [DataMember(Name = "HoldALotECommerceRequest")]
        public bool HoldALotECommerceRequest { get; set; }
        [DataMember(Name = "HoldALotECommerceSuccess")]
        public bool HoldALotECommerceSuccess { get; set; }
        [DataMember(Name = "LotId")]
        public string LotId { get; set; }
        [DataMember(Name = "BuilderEmail")]
        public string BuilderEmail { get; set; }
        [DataMember(Name = "includeMPC")]
        public bool includeMPC { get; set; }
        [DataMember(Name = "isMobileLead")]
        public bool isMobileLead { get; set; }
        [DataMember(Name = "ListingID")]
        public int ListingID { get; set; }
        [DataMember(Name = "SiteUrl")]
        public string SiteUrl { get; set; }
        [DataMember(Name = "LotName")]
        public string LotName { get; set; }
        [DataMember(Name = "LotAddress")]
        public string LotAddress { get; set; }
        [DataMember(Name = "LotReservationFee")]
        public string LotReservationFee { get; set; }
        [DataMember(Name = "LotInfo")]
        public string LotInfo { get; set; }
        [DataMember(Name = "ReceiptURL")]
        public string ReceiptURL { get; set; }
        [DataMember(Name = "ReceiptNumber")]
        public string ReceiptNumber { get; set; }
        [DataMember(Name = "BrandPartnerID")]
        public int BrandPartnerID { get; set; }
        [DataMember(Name = "SubPartnerID")]
        public int SubPartnerID { get; set; }
        [DataMember(Name = "PartnerLeadAction")]
        public string PartnerLeadAction { get; set; }
        [DataMember(Name = "IsLeadBilled")]
        public bool IsLeadBilled { get; set; }
        [DataMember(Name = "UserComments")]
        public string UserComments { get; set; }
        public ProspectLead ()
        {
            NumberOfRecommendations = 3;
        }

    }
}
