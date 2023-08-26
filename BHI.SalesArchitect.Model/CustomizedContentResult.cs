namespace BHI.SalesArchitect.Model
{
    public class CustomizedContentResult
    {
        public int Id { get; set; } 
        public string ContentType { get; set; }
        public string Value { get; set; }
        public int? CustomizedContentTypeId { get; set; }
        public int? PartnerId { get; set; }
        public int? CommunityId { get; set; }
        public string LocationDescription { get; set; }
        public string LocationCode { get; set; }
    }
}
