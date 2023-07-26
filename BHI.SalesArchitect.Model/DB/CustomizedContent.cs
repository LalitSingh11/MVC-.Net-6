namespace BHI.SalesArchitect.Model.DB;

public partial class CustomizedContent
{
    public int Id { get; set; }

    public int? PartnerId { get; set; }

    public int? CommunityId { get; set; }

    public int? SiteId { get; set; }

    public int? CustomizedContentTypeId { get; set; }

    public string? Value { get; set; }

    public bool isCommunityContent { get; set; }

    public virtual CustomizedContentType? CustomizedContentType { get; set; }
}
