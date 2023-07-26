using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class User
{
    public int Id { get; set; }

    public int ActivityStateId { get; set; }

    public int? PartnerId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ActivityState ActivityState { get; set; } = null!;

    public virtual ICollection<CommunityUser> CommunityUsers { get; set; } = new List<CommunityUser>();

    public virtual Partner? Partner { get; set; }

    public virtual ICollection<ProspectCommunity> ProspectCommunities { get; set; } = new List<ProspectCommunity>();

    public virtual ICollection<ProspectConfiguration> ProspectConfigurations { get; set; } = new List<ProspectConfiguration>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<UserSessionEventLog> UserSessionEventLogs { get; set; } = new List<UserSessionEventLog>();
}
