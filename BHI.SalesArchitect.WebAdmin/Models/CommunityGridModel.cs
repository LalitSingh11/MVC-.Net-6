namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class CommunityGridModel
    {
        public int id { get; set; }
        public Cell cell { get; set; }
    }
    public class Cell
    {
        public int ID { get; set; }
        public string DWStatus { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Market { get; set; }
        public int? LotsCount { get; set; }
        public int? ProspectCount { get; set; }
        public string Admins { get; set; }
        public string ActivityState { get; set; }
        public string Address { get; set; }
        public string Sites { get; set; }
        public string MasterSites { get; set; }
        public string Locked { get; set; }
        public string NewIsp { get; set; }
        public string ISPVersion { get; set; }
        public string Code { get; set; }
        public string NHSQRCode { get; set; }
        public string BuilderWebsiteQRCode { get; set; }
        public int BDXId { get; set; }
        public bool HasGeoJson { get; set; }
        public bool HasSVG { get; set; }
        public bool IsGeoSVG { get; set; }
        public bool IsMasterGeoSVG { get; set; }
        public string DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string ISPName { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }
    }
}


