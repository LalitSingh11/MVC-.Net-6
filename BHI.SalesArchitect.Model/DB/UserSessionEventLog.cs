using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class UserSessionEventLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime LoginTime { get; set; }

    public DateTime LogoutTime { get; set; }

    public virtual User User { get; set; } = null!;
}
