using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure
{
    public interface IProspectConfigurationRepository
    {
        ProspectConfiguration GetByPartnerId(int partnerId);
    }
}
