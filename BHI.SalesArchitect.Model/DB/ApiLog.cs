namespace BHI.SalesArchitect.Model.DB;

public partial class ApiLog
{
    public int Id { get; set; }

    public string? LogId { get; set; }

    public string? Api { get; set; }

    public int? Type { get; set; }

    public DateTime? Time { get; set; }
}
