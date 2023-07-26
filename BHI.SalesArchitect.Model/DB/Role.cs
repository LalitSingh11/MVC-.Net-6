using System;
using System.Collections.Generic;

namespace BHI.SalesArchitect.Model.DB;

public partial class Role
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<RoleAction> RoleActions { get; set; } = new List<RoleAction>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
