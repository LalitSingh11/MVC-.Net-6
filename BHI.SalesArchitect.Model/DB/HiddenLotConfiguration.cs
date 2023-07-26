using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class HiddenLotConfiguration
{
    public int Id { get; set; }

    public int SiteId { get; set; }

    public string LotInternalReference { get; set; } = null!;

    public string ConfigName { get; set; } = null!;
}
