using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class CustomizedContentType
{
    public int Id { get; set; }

    public int? CustomizedLocationId { get; set; }

    public string? ContentType { get; set; }

    public virtual CustomizedLocation? CustomizedLocation { get; set; }
}
