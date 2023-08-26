namespace BHI.SalesArchitect.Model.DB;

public partial class ListingImage
{
    public int Id { get; set; }

    public int ListingId { get; set; }

    public int PartnerId { get; set; }

    public string Type { get; set; } = null!;

    public string Url { get; set; }

    public int Sequence { get; set; }

    public DateTime ProcessDate { get; set; }

    public string Title { get; set; }

    public virtual Listing Listing { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
