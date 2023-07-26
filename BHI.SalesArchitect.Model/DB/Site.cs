using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class Site
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? MapData { get; set; }

    public string? MapImage { get; set; }

    public bool? ImageUpdate { get; set; }

    public string? PdfImage { get; set; }

    public string? Version { get; set; }

    public string? GeospatialPluginImage { get; set; }

    public string? GeospatialPluginPdfImage { get; set; }

    public bool? IsGeoSvg { get; set; }

    public virtual ICollection<CommunitySiteGeoJson> CommunitySiteGeoJsons { get; set; } = new List<CommunitySiteGeoJson>();

    public virtual ICollection<CommunitySite> CommunitySites { get; set; } = new List<CommunitySite>();

    public virtual ICollection<Lot> Lots { get; set; } = new List<Lot>();
}
