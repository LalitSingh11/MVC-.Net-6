using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class LotReservationLog
{
    public int Id { get; set; }

    public int LotId { get; set; }

    public string PaymentId { get; set; } = null!;

    public int PreviousLotStateId { get; set; }

    public int NewLotStateId { get; set; }

    public DateTime ReservationDate { get; set; }
}
