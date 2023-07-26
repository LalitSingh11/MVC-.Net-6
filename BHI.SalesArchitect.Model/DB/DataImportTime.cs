using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class DataImportTime
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public DateTime FileExportTime { get; set; }

    public DateTime TimeProcessed { get; set; }

    public virtual Partner Partner { get; set; } = null!;
}
