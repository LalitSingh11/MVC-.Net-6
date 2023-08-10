namespace BHI.SalesArchitect.Model.DB;

public partial class ProspectConfiguration
{
    public int Id { get; set; }

    public bool Phone { get; set; }

    public bool MailingAddress { get; set; }

    public bool ZipCode { get; set; }

    public bool GuestCardNumber { get; set; }

    public bool ReferralSources { get; set; }

    public int UserId { get; set; }

    public int PartnerId { get; set; }

    public bool? RequestInfoModal { get; set; }

    public bool? BuilderLogo { get; set; }

    public bool? EmailAllowed { get; set; }

    public bool? IsIsp { get; set; }

    public bool? ShowAllPlans { get; set; }

    public bool SendLotId { get; set; }

    public bool? ShowHomesiteFilter { get; set; }

    public int IspPartnerType { get; set; }

    public bool? IsHoverAllowed { get; set; }

    public bool? ShowBottombar { get; set; }

    public string GoogleApikey { get; set; }

    public string GoogleClientId { get; set; }

    public bool? HoldAlot { get; set; }

    public string BuilderEmail { get; set; }

    public string BuilderPhone { get; set; }

    public string BuilderDescription { get; set; }

    public bool? PreviewIspplugin { get; set; }

    public bool? IsDreamweaver { get; set; }

    public string Pdfdisclaimer { get; set; }

    public string HoldAlotDisclaimer { get; set; }

    public string HoldAlotButtonText { get; set; }

    public string HoldAlotHeaderText { get; set; }

    public string LotOutlineColor { get; set; }

    public bool? LotPremiumOptionalDisplay { get; set; }

    public bool? SuppressBuilderLogo { get; set; }

    public bool? SuppressBottomCommunityName { get; set; }

    public bool? SuppressTopCommunityName { get; set; }

    public bool? DisplayLotList { get; set; }

    public bool? DisplaySpecAddress { get; set; }

    public bool? AddModelHomesBanner { get; set; }

    public bool? ReplaceKeyIcon { get; set; }

    public bool? ShowAllSpecs { get; set; }

    public bool? OpenSpecDefault { get; set; }

    public string NhtbuilderNumber { get; set; }

    public bool? ShowExteriorColorScheme { get; set; }

    public bool? IsSecured { get; set; }

    public virtual Partner Partner { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
