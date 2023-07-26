using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ConsumerDevice
{
    public int Id { get; set; }

    public int? ConsumerId { get; set; }

    public string? DeviceToken { get; set; }
}
