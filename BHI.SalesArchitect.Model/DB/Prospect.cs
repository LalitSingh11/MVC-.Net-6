namespace BHI.SalesArchitect.Model.DB;

public partial class Prospect
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string HomePhone { get; set; }

    public string MobilePhone { get; set; }

    public string ZipCode { get; set; }

    public string CardNumber { get; set; }

    public string Address { get; set; }

    public string State { get; set; }

    public string City { get; set; }

    public string AccessKey { get; set; }

    public string WelcomeImage { get; set; }

    public int PartnerId { get; set; }

    public int CreatedByPartnerId { get; set; }

    public virtual ICollection<ProspectAsset> ProspectAssets { get; set; } = new List<ProspectAsset>();

    public virtual ICollection<ProspectCommunity> ProspectCommunities { get; set; } = new List<ProspectCommunity>();

    public virtual ICollection<ProspectListing> ProspectListings { get; set; } = new List<ProspectListing>();

    public virtual ICollection<ProspectLot> ProspectLots { get; set; } = new List<ProspectLot>();

    public virtual ICollection<ProspectReferralSource> ProspectReferralSources { get; set; } = new List<ProspectReferralSource>();
}
