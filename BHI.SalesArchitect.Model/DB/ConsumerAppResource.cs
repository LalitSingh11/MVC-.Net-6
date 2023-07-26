using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ConsumerAppResource
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? ParentId { get; set; }

    public string? Url { get; set; }

    public int Sequence { get; set; }

    public int? PartnerId { get; set; }

    public int? BuilderBrandId { get; set; }

    public virtual BuilderBrand? BuilderBrand { get; set; }

    public virtual ICollection<ConsumerAppResource> InverseParent { get; set; } = new List<ConsumerAppResource>();

    public virtual ConsumerAppResource? Parent { get; set; }

    public virtual Partner? Partner { get; set; }
}
