using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ProspectCommunity
{
    public int Id { get; set; }

    public int ProspectId { get; set; }

    public int CommunityId { get; set; }

    public int? UserId { get; set; }

    public DateTime LastDateOfVisit { get; set; }

    public int ActivityStateId { get; set; }

    public string? PrivateNotes { get; set; }

    public string? SharedNotes { get; set; }

    public bool? IsFavorite { get; set; }

    public string? ConsumerPrivateNotes { get; set; }

    public virtual ActivityState ActivityState { get; set; } = null!;

    public virtual Community Community { get; set; } = null!;

    public virtual Prospect Prospect { get; set; } = null!;

    public virtual ICollection<ProspectCommunityVisitDetail> ProspectCommunityVisitDetails { get; set; } = new List<ProspectCommunityVisitDetail>();

    public virtual User? User { get; set; }
}
