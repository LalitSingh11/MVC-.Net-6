namespace BHI.SalesArchitect.Model.DB;

public partial class ProspectReferralSource
{
    public int Id { get; set; }

    public int ProspectId { get; set; }

    public int ReferralSourceId { get; set; }

    public string CustomValue { get; set; }

    public virtual Prospect Prospect { get; set; } = null!;

    public virtual ReferralSource ReferralSource { get; set; } = null!;
}
