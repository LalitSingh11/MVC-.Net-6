﻿using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class LotState
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? PartnerId { get; set; }

    public virtual ICollection<Lot> Lots { get; set; } = new List<Lot>();

    public virtual Partner? Partner { get; set; }
}
