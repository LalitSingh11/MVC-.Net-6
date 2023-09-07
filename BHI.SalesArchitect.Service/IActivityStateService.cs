using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IActivityStateService
    {
        ActivityState ActiveState { get; }
        ActivityState InactiveState { get; }
    }
}
