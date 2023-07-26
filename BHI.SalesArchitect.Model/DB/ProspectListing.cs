using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ProspectListing
{
    public int Id { get; set; }

    public int ProspectId { get; set; }

    public int ListingId { get; set; }

    public virtual Listing Listing { get; set; } = null!;

    public virtual Prospect Prospect { get; set; } = null!;
}
