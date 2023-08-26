using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class Consumer
{
    public int Id { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string FacebookEmail { get; set; }

    public string FacebookId { get; set; }

    public string GoogleEmail { get; set; }

    public string GoogleId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastLogin { get; set; }

    public int? PartnerId { get; set; }

    public int? Source { get; set; }

    public int? Platform { get; set; }

    public virtual ICollection<ConsumerSessionEventLog> ConsumerSessionEventLogs { get; set; } = new List<ConsumerSessionEventLog>();

    public virtual ICollection<GuestConsumerLog> GuestConsumerLogs { get; set; } = new List<GuestConsumerLog>();

    public virtual ICollection<OneTimePassword> OneTimePasswords { get; set; } = new List<OneTimePassword>();

    public virtual Partner Partner { get; set; }
}
