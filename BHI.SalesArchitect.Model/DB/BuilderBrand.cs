namespace BHI.SalesArchitect.Model.DB;

public partial class BuilderBrand
{
    public int Id { get; set; }

    public int Bdxid { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<BuilderBrandListing> BuilderBrandListings { get; set; } = new List<BuilderBrandListing>();

    public virtual ICollection<CommunityBuilderBrand> CommunityBuilderBrands { get; set; } = new List<CommunityBuilderBrand>();

    public virtual ICollection<ConsumerAppConfigurable> ConsumerAppConfigurables { get; set; } = new List<ConsumerAppConfigurable>();

    public virtual ICollection<ConsumerAppResource> ConsumerAppResources { get; set; } = new List<ConsumerAppResource>();

    public virtual ICollection<PartnerBuilderBrand> PartnerBuilderBrands { get; set; } = new List<PartnerBuilderBrand>();
}
