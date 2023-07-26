using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class MasterPlan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string MapData { get; set; } = null!;

    public string? MapImage { get; set; }

    public bool? ImageUpdate { get; set; }

    public string? PdfImage { get; set; }

    public bool? IsMasterGeoSvg { get; set; }

    public string? GeospatialMapImage { get; set; }

    public string? GeospatialPdfImage { get; set; }

    public virtual ICollection<Community> Communities { get; set; } = new List<Community>();

    public virtual ICollection<PartnerMasterPlan> PartnerMasterPlans { get; set; } = new List<PartnerMasterPlan>();
}
