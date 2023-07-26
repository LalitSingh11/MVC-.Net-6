using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ProspectLot
{
    public int Id { get; set; }

    public int ProspectId { get; set; }

    public int LotId { get; set; }

    public int CommunityId { get; set; }

    public virtual Community Community { get; set; } = null!;

    public virtual Lot Lot { get; set; } = null!;

    public virtual Prospect Prospect { get; set; } = null!;
}
