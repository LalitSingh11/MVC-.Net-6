using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class SyncAction
{
    public long Id { get; set; }

    public int SyncActionTypeId { get; set; }

    public int RecordId { get; set; }

    public string Entity { get; set; } = null!;

    public string ActionOwner { get; set; } = null!;

    public DateTime EffectiveTime { get; set; }

    public int? PartnerId { get; set; }

    public int? CommunityId { get; set; }

    public virtual SyncActionType SyncActionType { get; set; } = null!;
}
