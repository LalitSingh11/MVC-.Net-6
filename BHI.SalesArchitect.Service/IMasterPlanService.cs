using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IMasterPlanService
    {
        MasterPlan GetByIdWithoutSvg(int masterSiteID);
    }
}
