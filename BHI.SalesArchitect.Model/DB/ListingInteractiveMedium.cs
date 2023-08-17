namespace BHI.SalesArchitect.Model.DB;

public partial class ListingInteractiveMedium
{
    public int Id { get; set; }

    public int ListingId { get; set; }

    public int PartnerId { get; set; }

    public string? Url { get; set; }

    public string? Title { get; set; }

    public int? Sequence { get; set; }

    public string? Type { get; set; }

    public virtual Listing Listing { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
