using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class ConfigurationService : IConfigurationService
    {
        private IConfigurationRepository _configurationRepository;
        public ConfigurationService(IConfigurationRepository configurationRepository)
        {
            _configurationRepository = configurationRepository;
        }
        public async Task<IEnumerable<Configuration>> GetIspConfigurationsByPartnerId(int partnerId)
        {
            return await _configurationRepository.GetIspConfigurationsByPartnerId(partnerId);
        }

        public async Task<bool> UpdatePopupTitlesConfiguration(Dictionary<string, string> popupTitlesDict, int partnerId)
        {
            var defaultConfigs = await _configurationRepository.GetIspDefaultConfigurations();
            await _configurationRepository.DeleteIspConfigByPartnerId(partnerId);
            List<Configuration> popupTitles = new();
            foreach (var config in defaultConfigs)
            {
                var updatedConfigValue = popupTitlesDict.Where(x => x.Key == config.Code).Select(x => x.Value).First();
                var configObj = new Configuration()
                {
                    Name = config.Name,
                    Code = config.Code,
                    AssetTypeId = config.AssetTypeId,
                    ConfigValue = String.IsNullOrWhiteSpace(updatedConfigValue) ? config.ConfigValue : updatedConfigValue,
                    PartnerId = partnerId
                };
                popupTitles.Add(configObj);
            }
            return await _configurationRepository.AddIspConfigByPartnerId(popupTitles);
        }
    }
}
