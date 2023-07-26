using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class OneTimePassword
{
    public int Id { get; set; }

    public string Otp { get; set; } = null!;

    public int ConsumerId { get; set; }

    public DateTime CreatedTime { get; set; }

    public bool IsExpired { get; set; }

    public virtual Consumer Consumer { get; set; } = null!;
}
