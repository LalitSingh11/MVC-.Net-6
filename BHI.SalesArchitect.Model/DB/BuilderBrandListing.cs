namespace BHI.SalesArchitect.Model.DB;

public partial class BuilderBrandListing
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public int BuilderBrandId { get; set; }

    public int CommunityId { get; set; }

    public int ListingId { get; set; }

    public DateTime? DateDeleted { get; set; }

    public string DeletedBy { get; set; }

    public virtual BuilderBrand BuilderBrand { get; set; } = null!;

    public virtual Community Community { get; set; } = null!;

    public virtual Listing Listing { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
