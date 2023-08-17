namespace BHI.SalesArchitect.Model.DB;

public partial class ActivityState
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Community> Communities { get; set; } = new List<Community>();

    public virtual ICollection<CommunityConfiguration> CommunityConfigurations { get; set; } = new List<CommunityConfiguration>();

    public virtual ICollection<CommunityUser> CommunityUsers { get; set; } = new List<CommunityUser>();

    public virtual ICollection<ProspectCommunity> ProspectCommunities { get; set; } = new List<ProspectCommunity>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
