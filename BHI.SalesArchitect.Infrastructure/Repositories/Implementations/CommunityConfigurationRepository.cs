using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CommunityConfigurationRepository : ICommunityConfigurationRepository
    {
        private SalesArchitectContext _dbContext;
        private IActivityStateRepository _activityStateRepository;
        public CommunityConfigurationRepository(SalesArchitectContext dbContext,
            IActivityStateRepository activityStateRepository)
        {
            _dbContext = dbContext;
            _activityStateRepository = activityStateRepository;
        }

        public async Task<IEnumerable<CommunityConfiguration>> GetById(int communityId)
        {
            var result = from cc in _dbContext.CommunityConfigurations
                         join acts in _dbContext.ActivityStates on cc.ActivityStateId equals acts.Id
                         join c in _dbContext.Configurations on cc.ConfigurationId equals c.Id
                         where cc.CommunityId == communityId
                         select new CommunityConfiguration
                         {
                             Id = cc.Id,
                             CommunityId = cc.CommunityId,
                             ConfigurationId = cc.ConfigurationId,
                             Value = cc.Value,
                             ActivityStateId = cc.ActivityStateId,
                             HoldAlotStatus = cc.HoldAlotStatus,
                             IncludeDwstatus = cc.IncludeDwstatus,
                             Sequence = cc.Sequence,
                             SuppressPriceStatus = cc.SuppressPriceStatus,
                             HoldAlotButtonText = cc.HoldAlotButtonText,
                             Configuration = c,
                         };
            return await result.ToListAsync();
        }
        public async Task<IEnumerable<CommunityConfiguration>> GetTitleSettingsForCommunity(int communityId)
        {
            var result = from cc in _dbContext.CommunityConfigurations
                         join c in _dbContext.Configurations on cc.ConfigurationId equals c.Id
                         where cc.CommunityId == communityId && c.AssetTypeId == 3
                         select new CommunityConfiguration
                         {
                             Id = cc.Id,
                             CommunityId = cc.CommunityId,
                             ConfigurationId = cc.ConfigurationId,
                             Value = cc.Value,
                             ActivityStateId = cc.ActivityStateId,
                             HoldAlotStatus = cc.HoldAlotStatus,
                             IncludeDwstatus = cc.IncludeDwstatus,
                             Sequence = cc.Sequence,
                             SuppressPriceStatus = cc.SuppressPriceStatus,
                             HoldAlotButtonText = cc.HoldAlotButtonText,
                             Configuration = c,
                         };
            return await result.ToListAsync();
        }
        public async Task<bool> AddTitleSettingsForCommunity(List<CommunityConfiguration> communityConfigurations)
        {
            await _dbContext.CommunityConfigurations.AddRangeAsync(communityConfigurations);
            return await _dbContext.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteTitleSettingsForCommunity(int communityId)
        {
            var communityConfigurations = await GetTitleSettingsForCommunity(communityId);
            _dbContext.CommunityConfigurations.RemoveRange(communityConfigurations);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<CommunityConfiguration>> GetActiveConfigurationByConfigIdForPartnerComms(int configId)
        {
            var result = from cc in _dbContext.CommunityConfigurations
                                     join acs in _dbContext.ActivityStates on cc.ActivityStateId equals acs.Id
                                     join c in _dbContext.Configurations on cc.ConfigurationId equals c.Id
                                     join pc in _dbContext.PartnerCommunities on cc.CommunityId equals pc.CommunityId
                                     where c.Id == configId && cc.ActivityStateId == _activityStateRepository.ActiveState.Id && c.PartnerId == pc.PartnerId
                                     select cc;
            return await result.ToListAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var configurationsToDelete = _dbContext.CommunityConfigurations.FirstOrDefault(cc => cc.ConfigurationId == id);
            _dbContext.CommunityConfigurations.Remove(configurationsToDelete);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
