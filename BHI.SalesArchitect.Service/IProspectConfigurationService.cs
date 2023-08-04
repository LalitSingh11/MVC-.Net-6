using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IProspectConfigurationService
    {
        ProspectConfiguration GetByPartnerId(int  partnerId);
    }
}
