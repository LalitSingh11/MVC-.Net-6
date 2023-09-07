using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly SalesArchitectContext _dbContext;
        public ConfigurationRepository(SalesArchitectContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Configuration>> GetIspConfigurationsByPartnerId(int partnerId)
        {
            var result = from c in _dbContext.Configurations
                        join at in _dbContext.AssetTypes on c.AssetTypeId equals at.Id
                        where (c.PartnerId == partnerId)
                           && c.AssetTypeId == 3
                           && c.Code.StartsWith("ISP")
                        select c;
            if(result.Any())
            {
                return await result.ToListAsync();
            }
            return await GetIspDefaultConfigurations();
        }

        public async Task<IEnumerable<Configuration>> GetIspDefaultConfigurations()
        {
            var result = from c in _dbContext.Configurations
                         join at in _dbContext.AssetTypes on c.AssetTypeId equals at.Id
                         where c.PartnerId == null
                            && c.AssetTypeId == 3
                            && c.Code.StartsWith("ISP")
                         select c;

            return await result.ToListAsync();
        }

        public async Task<bool> DeleteIspConfigByPartnerId(int partnerId)
        {
            var existingConfig = _dbContext.Configurations.
                Where(x => x.PartnerId == partnerId && x.Code.StartsWith("ISP"));
            _dbContext.Configurations.RemoveRange(existingConfig);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddIspConfigByPartnerId(List<Configuration> popupConfigurations)
        {
            await _dbContext.Configurations.AddRangeAsync(popupConfigurations);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
