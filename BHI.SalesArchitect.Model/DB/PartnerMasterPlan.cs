using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class PartnerMasterPlan
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public int MasterPlanId { get; set; }

    public virtual MasterPlan MasterPlan { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
