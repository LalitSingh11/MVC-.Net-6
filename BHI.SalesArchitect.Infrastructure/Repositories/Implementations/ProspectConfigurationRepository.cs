using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class ProspectConfigurationRepository : IProspectConfigurationRepository
    {
        private SalesArchitectContext _dbContext;
        public ProspectConfigurationRepository(SalesArchitectContext dbContext)
        {

            _dbContext = dbContext;

        }
        public ProspectConfiguration GetByPartnerId(int partnerId)
        {
            return _dbContext.ProspectConfigurations.Where(x => x.PartnerId == partnerId).FirstOrDefault(); 
        }
    }
}
