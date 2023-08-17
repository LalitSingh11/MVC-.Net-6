namespace BHI.SalesArchitect.Model.DB;

public partial class RoleAction
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int ActionId { get; set; }

    public bool Allowed { get; set; }

    public virtual Action Action { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
