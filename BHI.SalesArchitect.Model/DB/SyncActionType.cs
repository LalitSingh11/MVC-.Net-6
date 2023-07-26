using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class SyncActionType
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<SyncAction> SyncActions { get; set; } = new List<SyncAction>();
}
