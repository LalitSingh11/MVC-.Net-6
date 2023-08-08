using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class ProspectConfigurationService : IProspectConfigurationService
    {
        private IProspectConfigurationRepository _prospectConfigurationRepository;
        public ProspectConfigurationService(IProspectConfigurationRepository prospectConfigurationRepository)
        {
            _prospectConfigurationRepository = prospectConfigurationRepository;
        }
        public ProspectConfiguration GetByPartnerId(int partnerId)
        {
            return _prospectConfigurationRepository.GetByPartnerId(partnerId);
        }
    }
}
