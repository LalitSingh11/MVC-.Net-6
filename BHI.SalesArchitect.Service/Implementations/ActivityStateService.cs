using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class ActivityStateService : IActivityStateService
    {
        private IActivityStateRepository _activityStateRepository;
        public ActivityStateService(IActivityStateRepository activityStateRepository)
        {
            _activityStateRepository = activityStateRepository;
        }
        public ActivityState ActiveState => _activityStateRepository.ActiveState;
        public ActivityState InactiveState => _activityStateRepository.InactiveState;
    }
}
