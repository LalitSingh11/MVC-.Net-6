using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ConsumerSessionEventLog
{
    public int Id { get; set; }

    public int ConsumerId { get; set; }

    public DateTime LoginTime { get; set; }

    public DateTime LogoutTime { get; set; }

    public virtual Consumer Consumer { get; set; } = null!;
}
