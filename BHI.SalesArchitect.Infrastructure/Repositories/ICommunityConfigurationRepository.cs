using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunityConfigurationRepository
    {
        public Task<IEnumerable<CommunityConfiguration>> GetTitleSettingsForCommunity(int communityId);
        public Task<IEnumerable<CommunityConfiguration>> GetById(int communityId);
        Task<bool> DeleteTitleSettingsForCommunity(int communityId);
        Task<bool> Delete(int id);
        Task<IEnumerable<CommunityConfiguration>> GetActiveConfigurationByConfigIdForPartnerComms(int configId);
        Task<bool> AddTitleSettingsForCommunity(List<CommunityConfiguration> communityConfigurations);
    }
}
