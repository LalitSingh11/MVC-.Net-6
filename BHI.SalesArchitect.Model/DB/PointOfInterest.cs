using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class PointOfInterest
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CommunityNearByPoi> CommunityNearByPois { get; set; } = new List<CommunityNearByPoi>();

    public virtual ICollection<CommunityPointOfInterest> CommunityPointOfInterests { get; set; } = new List<CommunityPointOfInterest>();
}
