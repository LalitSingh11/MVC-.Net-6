using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class CommunityUser
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int UserId { get; set; }

    public int ActivityStateId { get; set; }

    public virtual ActivityState ActivityState { get; set; } = null!;

    public virtual Community Community { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
