namespace BHI.SalesArchitect.Model.DB;

public partial class CustomizedLocation
{
    public int Id { get; set; }

    public string LocationCode { get; set; }

    public string Description { get; set; }

    public virtual ICollection<CustomizedContentType> CustomizedContentTypes { get; set; } = new List<CustomizedContentType>();
}
