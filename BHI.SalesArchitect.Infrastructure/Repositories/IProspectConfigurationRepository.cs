using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IProspectConfigurationRepository
    {
        ProspectConfiguration GetByPartnerId(int partnerId);
    }
}
