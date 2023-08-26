using System.Diagnostics;

namespace BHI.SalesArchitect.Model.DB;

[DebuggerDisplay("Code={Code}")]
public partial class Configuration
{
    public int Id { get; set; }

    public int AssetTypeId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? PartnerId { get; set; }

    public string ConfigValue { get; set; }

    public virtual AssetType AssetType { get; set; } = null!;

    public virtual ICollection<CommunityConfiguration> CommunityConfigurations { get; set; } = new List<CommunityConfiguration>();

    public virtual Partner Partner { get; set; }
}
