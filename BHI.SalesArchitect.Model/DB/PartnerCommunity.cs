using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class PartnerCommunity
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public int CommunityId { get; set; }

    public string Nhsqrcode { get; set; }

    public string BuilderWebsiteQrcode { get; set; }

    public DateTime? DateDeleted { get; set; }

    public string DeletedBy { get; set; }

    public virtual Community Community { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
