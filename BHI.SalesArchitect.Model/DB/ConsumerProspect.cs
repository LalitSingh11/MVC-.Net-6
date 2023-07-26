using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class ConsumerProspect
{
    public int Id { get; set; }

    public int? ConsumerId { get; set; }

    public int ProspectId { get; set; }
}
