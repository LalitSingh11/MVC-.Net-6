using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class PartnerListing
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public int ListingId { get; set; }

    public virtual Listing Listing { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
