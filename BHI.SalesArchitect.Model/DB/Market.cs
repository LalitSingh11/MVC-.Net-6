using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class Market
{
    public int Id { get; set; }

    public int Bdxid { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Community> Communities { get; set; } = new List<Community>();
}
