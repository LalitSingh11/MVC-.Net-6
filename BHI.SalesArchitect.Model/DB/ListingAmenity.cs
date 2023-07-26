using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ListingAmenity
{
    public int Id { get; set; }

    public int ListingId { get; set; }

    public int PartnerId { get; set; }

    public string? Amenity { get; set; }

    public int? Count { get; set; }

    public virtual Listing Listing { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
