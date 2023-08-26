using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class CommunityVideoTour
{
    public int Id { get; set; }

    public int CommunityId { get; set; }

    public int PartnerId { get; set; }

    public string Url { get; set; }

    public virtual Community Community { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
