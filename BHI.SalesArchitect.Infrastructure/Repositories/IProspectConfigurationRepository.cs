using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IProspectConfigurationRepository
    {
        Task<ProspectConfiguration> GetByPartnerId(int partnerId);
        Task<bool> Update(ProspectConfiguration config);
        Task<bool> Insert(ProspectConfiguration configuration);
    }
}
