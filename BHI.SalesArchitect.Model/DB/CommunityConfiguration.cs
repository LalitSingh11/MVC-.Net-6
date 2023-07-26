using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class CommunityConfiguration
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int ConfigurationId { get; set; }

    public string Value { get; set; } = null!;

    public int ActivityStateId { get; set; }

    public bool? HoldAlotStatus { get; set; }

    public bool IncludeDwstatus { get; set; }

    public int? Sequence { get; set; }

    public bool SuppressPriceStatus { get; set; }

    public string? HoldAlotButtonText { get; set; }

    public virtual ActivityState ActivityState { get; set; } = null!;

    public virtual Community Community { get; set; } = null!;

    public virtual Configuration Configuration { get; set; } = null!;
}
