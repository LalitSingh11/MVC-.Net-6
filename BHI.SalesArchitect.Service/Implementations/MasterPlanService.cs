using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class MasterPlanService : IMasterPlanService
    {
        private IMasterPlanRepository _MasterPlanRepository;
        public MasterPlanService(IMasterPlanRepository masterPlanRepository)
        {
            _MasterPlanRepository = masterPlanRepository;
        }
        public MasterPlan GetByIdWithoutSvg(int masterSiteID)
        {
            return _MasterPlanRepository.GetByIdWithoutSvg(masterSiteID);
        }
    }
}
