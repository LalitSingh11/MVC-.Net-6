using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ICommunityConfigurationService
    {
        Task<IEnumerable<CommunityConfiguration>> GetISPConfigById(int communityId);
        Task<bool> Delete(int id);
        public Task<IEnumerable<CommunityConfiguration>> GetTitleSettingsForCommunity(int communityId);
        Task<IEnumerable<CommunityConfiguration>> GetLotStatusConfigByCommId(int partnerId, int communityId);
        public Task<bool> UpdateTitleSettingsForCommunity(int communityId, Dictionary<string, string> popupTitlesDict);
        Task<IEnumerable<CommunityConfiguration>> GetActiveConfigurationByConfigIdForPartnerComms(int configId);
    }
}
