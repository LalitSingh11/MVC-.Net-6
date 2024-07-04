using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CommunityConfigurationService : ICommunityConfigurationService
    {
        private readonly ICommunityConfigurationRepository _communityConfigurationRepository;
        private readonly IConfigurationRepository _configurationRepository;
        private readonly IActivityStateRepository _activityStateRepository;
        public CommunityConfigurationService(ICommunityConfigurationRepository communityConfigurationService,
            IConfigurationRepository configurationRepository,
            IActivityStateRepository activityStateRepository)
        {
            _communityConfigurationRepository = communityConfigurationService;
            _configurationRepository = configurationRepository;
            _activityStateRepository = activityStateRepository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _communityConfigurationRepository.Delete(id);
        }

        public async Task<IEnumerable<CommunityConfiguration>> GetActiveConfigurationByConfigIdForPartnerComms(int configId)
        {
            return await _communityConfigurationRepository.GetActiveConfigurationByConfigIdForPartnerComms(configId);
        }

        public async Task<IEnumerable<CommunityConfiguration>> GetISPConfigById(int communityId)
        {
            var config =  await _communityConfigurationRepository.GetById(communityId);
            return config.Where(x => x.Configuration.Code.StartsWith("COMM"));
        }

        public async Task<IEnumerable<CommunityConfiguration>> GetLotStatusConfigByCommId(int partnerId, int communityId)
        {
            var commConfig = await _communityConfigurationRepository.GetById(communityId);
            /*var config = await _configurationRepository.GetByPartnerId(partnerId);
            var co = from c in config
                            join cc in commConfig
                              on c.Id equals cc.ConfigurationId into joinConfigs
                            from fd in joinConfigs.DefaultIfEmpty()
                            select new CommunityConfiguration
                            {
                                Id = fd == null ? 0 : fd.Id,
                                ConfigurationId = c.Id,
                                Value = fd == null ? DefaultColors.GetByCode(c.Code) : fd.Value,
                                HoldAlotStatus = fd != null && fd.HoldAlotStatus,
                                ActivityStateId = fd == null ? 2 : fd.ActivityStateId,
                                IncludeDwstatus = fd != null && fd.IncludeDwstatus,
                                SuppressPriceStatus = fd != null && fd.SuppressPriceStatus,
                                HoldAlotButtonText = fd == null ? String.Empty : fd.HoldAlotButtonText,
                                Configuration = c
                            };*/
            return commConfig.Where(x => x.Configuration.Code.StartsWith("SPSTSCLR")).OrderBy(x => x.Id);
        }

        public async Task<IEnumerable<CommunityConfiguration>> GetTitleSettingsForCommunity(int communityId)
        {
            return await _communityConfigurationRepository.GetTitleSettingsForCommunity(communityId);
        }

        public async Task<bool> UpdateTitleSettingsForCommunity(int communityId, Dictionary<string, string> popupTitlesDict)
        {
            var configurations = await _configurationRepository.GetCommDefaultConfigurations();
            Dictionary<string, int> codeToIdMap = configurations.ToDictionary(item => item.Code, item => item.Id);
            List<CommunityConfiguration> communityConfigurations = new();
            foreach (var popupTitle in popupTitlesDict)
            {
                var commConfig = new CommunityConfiguration
                {
                    CommunityId = communityId,
                    ConfigurationId = codeToIdMap[popupTitle.Key],
                    Value = popupTitle.Value,
                    ActivityStateId = _activityStateRepository.ActiveState.Id
                };
                communityConfigurations.Add(commConfig);
            }
            await _communityConfigurationRepository.DeleteTitleSettingsForCommunity(communityId);
            return await _communityConfigurationRepository.AddTitleSettingsForCommunity(communityConfigurations);
        }
    }
}
