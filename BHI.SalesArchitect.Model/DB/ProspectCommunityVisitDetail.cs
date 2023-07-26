using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ProspectCommunityVisitDetail
{
    public int Id { get; set; }

    public int ProspectCommunityId { get; set; }

    public DateTime VisitDate { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual ProspectCommunity ProspectCommunity { get; set; } = null!;
}
