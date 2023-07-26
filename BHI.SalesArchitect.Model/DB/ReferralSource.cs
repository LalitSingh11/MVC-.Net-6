using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ReferralSource
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? SubTitle { get; set; }

    public int? FieldType { get; set; }

    public string? PlaceholderText { get; set; }

    public virtual ICollection<ProspectReferralSource> ProspectReferralSources { get; set; } = new List<ProspectReferralSource>();
}
