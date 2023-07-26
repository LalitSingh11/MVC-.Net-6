using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class UupuserLot
{
    public int Id { get; set; }

    public string UupuserId { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public int LotId { get; set; }

    public int BdxpartnerId { get; set; }

    public int BdxcommunityId { get; set; }

    public string? SiteImageName { get; set; }
}
