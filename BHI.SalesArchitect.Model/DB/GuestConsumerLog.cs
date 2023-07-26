using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class GuestConsumerLog
{
    public int Id { get; set; }

    public int ConsumerId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public bool IsGuest { get; set; }

    public virtual Consumer Consumer { get; set; } = null!;
}
