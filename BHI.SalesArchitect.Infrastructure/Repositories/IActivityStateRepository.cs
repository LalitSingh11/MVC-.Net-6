using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IActivityStateRepository
    {
        IEnumerable<ActivityState> GetAll();
        ActivityState ActiveState { get; }
        ActivityState InactiveState { get; }
    }
}
