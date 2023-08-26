using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class Feedback
{
    public int Id { get; set; }

    public int ConsumerId { get; set; }

    public int FeedbackCategoryId { get; set; }

    public string Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Platform { get; set; }

    public int? PartnerId { get; set; }

    public virtual Consumer Consumer { get; set; } = null!;

    public virtual Partner Partner { get; set; }
}
