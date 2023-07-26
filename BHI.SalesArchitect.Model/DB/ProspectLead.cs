using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ProspectLead
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? ZipCode { get; set; }

    public string? Comments { get; set; }

    public int? CommunityId { get; set; }

    public int? BuilderId { get; set; }

    public DateTime? SubmitDate { get; set; }

    public string? ActionOwner { get; set; }

    public string? Response { get; set; }

    public int? PartnerId { get; set; }

    public bool? IsApilead { get; set; }

    public string? LeadType { get; set; }

    public string? LeadAction { get; set; }

    public string? LeadPostingPassword { get; set; }

    public int? Platform { get; set; }

    public int? ProspectId { get; set; }

    public int? ListingId { get; set; }
}
