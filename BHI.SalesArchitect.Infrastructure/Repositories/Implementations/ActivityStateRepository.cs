using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class ActivityStateRepository : IActivityStateRepository
    {
        private SalesArchitectContext _dbContext;
        public ActivityStateRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
            Initialization();
        }
        public ActivityState ActiveState { get; private set; }
        public ActivityState InactiveState { get; private set; }

        public IEnumerable<ActivityState> GetAll()
        {
            return _dbContext.ActivityStates.ToList();
        }
        private void Initialization()
        {
            var activityStates = GetAll();

            ActiveState = activityStates.FirstOrDefault(p => p.Code == "ACTIVE");
            InactiveState = activityStates.FirstOrDefault(p => p.Code == "INACTIVE");
        }
    }    
}
