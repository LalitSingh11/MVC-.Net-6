using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class HiddenSiteBlock
{
    public int Id { get; set; }

    public int SiteId { get; set; }

    public int BlockNumber { get; set; }
}
