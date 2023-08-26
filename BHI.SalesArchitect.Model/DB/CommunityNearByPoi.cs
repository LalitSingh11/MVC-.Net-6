using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class CommunityNearByPoi
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; }

    public string State { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public int PointOfInterestId { get; set; }

    public double? Distance { get; set; }

    public int CommunityId { get; set; }

    public virtual Community Community { get; set; } = null!;

    public virtual PointOfInterest PointOfInterest { get; set; } = null!;
}
