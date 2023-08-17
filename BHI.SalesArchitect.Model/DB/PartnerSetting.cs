namespace BHI.SalesArchitect.Model.DB;

public partial class PartnerSetting
{
    public int Id { get; set; }

    public int? PartnerId { get; set; }

    public string Key { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Category { get; set; } = null!;

    public virtual Partner? Partner { get; set; }
}
