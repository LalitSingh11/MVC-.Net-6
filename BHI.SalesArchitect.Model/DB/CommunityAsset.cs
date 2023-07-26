using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class CommunityAsset
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int AssetTypeId { get; set; }

    public string Value { get; set; } = null!;

    public string? Description { get; set; }

    public int PartnerId { get; set; }

    public int? Sequence { get; set; }

    public string? Title { get; set; }

    public virtual AssetType AssetType { get; set; } = null!;

    public virtual Community Community { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
