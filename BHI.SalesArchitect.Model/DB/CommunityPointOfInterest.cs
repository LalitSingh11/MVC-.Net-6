using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class CommunityPointOfInterest
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int PointOfInterestId { get; set; }

    public bool IsGeospatial { get; set; }

    public virtual Community Community { get; set; } = null!;

    public virtual PointOfInterest PointOfInterest { get; set; } = null!;
}
