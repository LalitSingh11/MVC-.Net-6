namespace BHI.SalesArchitect.Model
{
    public class GridCommunityResult
    {
        public int Id { get; set; }
        public int Bdxid { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public int ActivityStateId { get; set; }
        public string ActivityStateName { get; set; }
        public string Name { get; set; } = null!;
        public string Admins { get; set; }
        public bool Locked { get; set; }
        public string VendorReference { get; set; }
        public string Brand { get; set; }
        public int? LotCount { get; set; }
        public int? ProspectCount { get; set; }
        public string Ispname { get; set; }
        public bool Status { get; set; }
        public int? Dwstatus { get; set; }
        public bool NewIsp { get; set; }
        public int? PreferredCommunityAssetId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }
    }

}
