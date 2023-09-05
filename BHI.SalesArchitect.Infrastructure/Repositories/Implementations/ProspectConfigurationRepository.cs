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

        public async Task<bool> Update(ProspectConfiguration configuration)
        {
            _dbContext.Update(configuration);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Insert(ProspectConfiguration configuration)
        {
            _dbContext.Add(configuration);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
