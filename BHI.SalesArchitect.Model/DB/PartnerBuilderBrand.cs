using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class PartnerBuilderBrand
{
    public int Id { get; set; }

    public int PartnerId { get; set; }

    public int BuilderBrandId { get; set; }

    public virtual BuilderBrand BuilderBrand { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;
}
