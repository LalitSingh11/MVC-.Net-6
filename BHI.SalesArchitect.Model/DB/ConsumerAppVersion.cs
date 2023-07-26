using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ConsumerAppVersion
{
    public int Id { get; set; }

    public string Version { get; set; } = null!;

    public bool IsMajorUpdate { get; set; }

    public bool IsDeleted { get; set; }
}
