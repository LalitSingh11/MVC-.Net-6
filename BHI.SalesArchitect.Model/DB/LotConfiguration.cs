namespace BHI.SalesArchitect.Model.DB;

public partial class LotConfiguration
{
    public int Id { get; set; }

    public int SiteId { get; set; }

    public int LotId { get; set; }

    public string ConfigType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
