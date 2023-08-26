using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ConsumerAppConfigurable
{
    public int Id { get; set; }

    public string DesignIntroText { get; set; } = null!;

    public string DesignDoYouKnow { get; set; } = null!;

    public int PartnerId { get; set; }

    public int? BuilderBrandId { get; set; }

    public virtual BuilderBrand BuilderBrand { get; set; }

    public virtual Partner Partner { get; set; } = null!;
}
