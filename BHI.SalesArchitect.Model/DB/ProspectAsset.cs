using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ProspectAsset
{
    public int Id { get; set; }

    public int ProspectId { get; set; }

    public int? ListingId { get; set; }

    public int AssetTypeId { get; set; }

    public string Value { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int? CommunityId { get; set; }

    public virtual AssetType AssetType { get; set; } = null!;

    public virtual Listing? Listing { get; set; }

    public virtual Prospect Prospect { get; set; } = null!;
}
