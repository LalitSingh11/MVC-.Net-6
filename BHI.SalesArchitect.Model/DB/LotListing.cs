using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class LotListing
{
    public int Id { get; set; }

    public int LotId { get; set; }

    public int ListingId { get; set; }

    public decimal? Price { get; set; }

    public int? ListingImagesId { get; set; }

    public virtual Listing Listing { get; set; } = null!;

    public virtual Lot Lot { get; set; } = null!;
}
