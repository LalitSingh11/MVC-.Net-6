namespace BHI.SalesArchitect.Model.DB;

public partial class CommunitySiteGeoJson
{
    public int Id { get; set; }

    public string GeoJsonfilePath { get; set; } = null!;

    public int SiteId { get; set; }

    public int CommunityId { get; set; }

    public int GeoJsontype { get; set; }

    public string? Version { get; set; }

    public int? ActivityStateId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UserId { get; set; }

    public string? GeoJsonfileName { get; set; }

    public virtual Community Community { get; set; } = null!;

    public virtual Site Site { get; set; } = null!;
}
