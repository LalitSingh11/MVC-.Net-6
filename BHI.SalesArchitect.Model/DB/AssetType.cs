using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class AssetType
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Configuration> Configurations { get; set; } = new List<Configuration>();

    public virtual ICollection<ProspectAsset> ProspectAssets { get; set; } = new List<ProspectAsset>();
}
