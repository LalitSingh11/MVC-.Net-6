using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class ProspectConfigurationRepository : IProspectConfigurationRepository
    {
        private SalesArchitectContext _dbContext;
        public ProspectConfigurationRepository(SalesArchitectContext dbContext)
        {

            _dbContext = dbContext;

        }
        public async Task<ProspectConfiguration> GetByPartnerId(int partnerId)
        {
            return await _dbContext.ProspectConfigurations.Where(x => x.PartnerId == partnerId).FirstOrDefaultAsync(); 
        }

        public async Task<bool> Update(ProspectConfiguration config)
        {
            _dbContext.Update(config);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
