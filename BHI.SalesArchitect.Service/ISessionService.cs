namespace BHI.SalesArchitect.Service
{
    public interface ISessionService
    {
        int? UserID { get; set; }
        int? PartnerID { get; set; }
        int? CommunityID { get; set; }
        string PartnerName { get; set; }
        string PartnerDataKey { get; set; }
        bool IsIsp { get; set; }
    }
}
