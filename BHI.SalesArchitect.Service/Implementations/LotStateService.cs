using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class LotStateService : ILotStateService
    {
        private ILotStateRepository _lotStateRepository;
        private ICommunityConfigurationRepository _communityConfigurationRepository;
        private IConfigurationRepository _configurationRepository;
        private IActivityStateRepository _activityStateRepository;
        public LotStateService(ILotStateRepository lotStateRepository,
            ICommunityConfigurationRepository communityConfigurationRepository,
            IConfigurationRepository configurationRepository,
            IActivityStateRepository activityStateRepository)
        {
            _lotStateRepository = lotStateRepository;
            _communityConfigurationRepository = communityConfigurationRepository;
            _configurationRepository = configurationRepository;
            _activityStateRepository = activityStateRepository;
        }

        public async Task<bool> DeleteByConfigId(int configId)
        {
            return await _lotStateRepository.DeleteByConfigId(configId);
        }

        public async Task<IEnumerable<LotState>> GetByConfigId(int configId)
        {
            return await _lotStateRepository.GetByConfigId(configId);
        }

        public async Task<IEnumerable<LotState>> GetByPartnerIdAndCommId(int partnerId, int commId)
        {
            var lotStates =  await _lotStateRepository.GetByPartnerId(partnerId);
            var commConfiguration = await _communityConfigurationRepository.GetById(commId);
            var configuration = await _configurationRepository.GetByPartnerId(partnerId);
            var result = from ls in lotStates
                        join c in configuration
                            on new { Name = ls.Name.ToUpper(), ls.PartnerId }
                            equals new { Name = c.Name.ToUpper(), c.PartnerId }
                        join cc in commConfiguration
                            on c.Id equals cc.Configuration.Id
                        where cc.ActivityStateId == _activityStateRepository.ActiveState.Id
                        select ls;
            return result.ToList();
        }

        public async Task<IEnumerable<LotState>> GetHoldALotStatusByPartnerIdAndCommId(int partnerId, int commId)
        {
            var lotStates = await _lotStateRepository.GetByPartnerId(partnerId);
            var commConfiguration = await _communityConfigurationRepository.GetById(commId);
            var configuration = await _configurationRepository.GetByPartnerId(partnerId);
            var result = from ls in lotStates
                         join c in configuration
                             on new { Name = ls.Name.ToUpper(), ls.PartnerId }
                             equals new { Name = c.Name.ToUpper(), c.PartnerId }
                         join cc in commConfiguration
                             on c.Id equals cc.Configuration.Id
                         where cc.ActivityStateId == _activityStateRepository.ActiveState.Id && !cc.HoldAlotStatus
                         select ls;
            return result.ToList();
        }
    }
}
