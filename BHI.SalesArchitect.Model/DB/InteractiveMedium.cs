using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class InteractiveMedium
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int PartnerId { get; set; }

    public string? Url { get; set; }

    public string? Title { get; set; }

    public int? Sequence { get; set; }

    public string? Type { get; set; }

    public virtual Community Community { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
