using System.Diagnostics;

namespace BHI.SalesArchitect.Model.DB;

[DebuggerDisplay("ID={Id}")]
public partial class Lot
{
    public int Id { get; set; }

    public int SiteId { get; set; }

    public int LotStateId { get; set; }

    public string InternalReference { get; set; } = null!;

    public string ExternalReference { get; set; }

    public string Size { get; set; }

    public string Block { get; set; }

    public string Phase { get; set; }

    public string Description { get; set; }

    public string Address { get; set; }

    public string Elevation { get; set; }

    public string Swing { get; set; }

    public int? PremiumPrice { get; set; }

    public string ImagePath { get; set; }

    public string ContactLink { get; set; }

    public string LotDescription { get; set; }

    public string ButtonText { get; set; }

    public bool IsAmenity { get; set; }

    public string DisplayName { get; set; }

    public string VideoUrl { get; set; }

    public decimal? ReservationFee { get; set; }

    public virtual ICollection<LotListing> LotListings { get; set; } = new List<LotListing>();

    public virtual LotState LotState { get; set; } = null!;

    public virtual ICollection<ProspectLot> ProspectLots { get; set; } = new List<ProspectLot>();

    public virtual Site Site { get; set; } = null!;
}
