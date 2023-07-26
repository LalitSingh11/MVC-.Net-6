using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class CommunitySite
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int SiteId { get; set; }

    public virtual Community Community { get; set; } = null!;

    public virtual Site Site { get; set; } = null!;
}
