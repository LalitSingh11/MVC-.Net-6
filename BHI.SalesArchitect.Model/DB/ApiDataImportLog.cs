namespace BHI.SalesArchitect.Model.DB;

public partial class ApiDataImportLog
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public int? CommunityId { get; set; }

    public int? UserId { get; set; }

    public DateTime? SyncStartTime { get; set; }

    public DateTime? SyncEndTime { get; set; }
}
