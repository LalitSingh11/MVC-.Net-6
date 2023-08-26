using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class ProspectConfigurationService : IProspectConfigurationService
    {
        private IProspectConfigurationRepository _prospectConfigurationRepository;
        private readonly ISessionService _sessionService;
        public ProspectConfigurationService(IProspectConfigurationRepository prospectConfigurationRepository,
            ISessionService sessionService)
        {
            _prospectConfigurationRepository = prospectConfigurationRepository;
            _sessionService = sessionService;
        }
        public async Task<ProspectConfiguration> GetByPartnerId(int partnerId)
        {
            var result =  await _prospectConfigurationRepository.GetByPartnerId(partnerId);
            return result ?? GetDefaultProspectConfigurations();
        }

        public async Task<bool> SaveProspectConfiguration(int partnerId, int userId, ProspectConfiguration prospectConfiguration)
        {
            var existingConfig = await GetByPartnerId(partnerId);

            existingConfig.PartnerId = partnerId;
            existingConfig.UserId = userId;
            existingConfig.IsIsp = prospectConfiguration.IsIsp;
            existingConfig.IsSecured = prospectConfiguration.IsSecured;
            existingConfig.ShowAllPlans = prospectConfiguration.ShowAllPlans;
            existingConfig.ShowAllSpecs = prospectConfiguration.ShowAllSpecs;
            existingConfig.IsHoverAllowed = prospectConfiguration.IsHoverAllowed;
            existingConfig.RequestInfoModal = prospectConfiguration.RequestInfoModal;
            existingConfig.SendLotId = prospectConfiguration.SendLotId;
            existingConfig.LotPremiumOptionalDisplay = prospectConfiguration.LotPremiumOptionalDisplay;
            existingConfig.SuppressBuilderLogo = prospectConfiguration.SuppressBuilderLogo;
            existingConfig.SuppressBottomCommunityName = prospectConfiguration.SuppressBottomCommunityName;
            existingConfig.SuppressTopCommunityName = prospectConfiguration.SuppressTopCommunityName;
            existingConfig.DisplayLotList = prospectConfiguration.DisplayLotList;
            existingConfig.DisplaySpecAddress = prospectConfiguration.DisplaySpecAddress;
            existingConfig.AddModelHomesBanner = prospectConfiguration.AddModelHomesBanner;
            existingConfig.ReplaceKeyIcon = prospectConfiguration.ReplaceKeyIcon;   
            existingConfig.OpenSpecDefault = prospectConfiguration.OpenSpecDefault; 
            existingConfig.ShowExteriorColorScheme = prospectConfiguration.ShowExteriorColorScheme;
            existingConfig.ShowHomesiteFilter = prospectConfiguration.ShowHomesiteFilter;
            existingConfig.ShowBottombar = prospectConfiguration.ShowBottombar;
            existingConfig.LotOutlineColor = prospectConfiguration.LotOutlineColor;

            return await _prospectConfigurationRepository.Update(existingConfig);
        }

        #region Private Methods
        private ProspectConfiguration GetDefaultProspectConfigurations()
        {
            return new ProspectConfiguration
            {
                Phone = true,
                ZipCode = true,
                GuestCardNumber = true,
                MailingAddress = true,
                ReferralSources = true,
                RequestInfoModal = true,
                BuilderLogo = false,
                EmailAllowed = false,
                IsIsp = false,
                ShowAllPlans = true,
                SendLotId = false,
                ShowHomesiteFilter = false,
                IsHoverAllowed = true,
                ShowBottombar = true,
                IspPartnerType = 1,
                GoogleApikey = String.Empty,
                GoogleClientId = String.Empty,
                HoldAlot = false,
                BuilderEmail = String.Empty,
                BuilderPhone = String.Empty,
                BuilderDescription = String.Empty,
                PreviewIspplugin = false,
                IsDreamweaver = false,
                LotPremiumOptionalDisplay = false,
                SuppressBuilderLogo = false,
                SuppressBottomCommunityName = false,
                SuppressTopCommunityName = false,
                DisplayLotList = false,
                DisplaySpecAddress = false,
                ShowAllSpecs = true,
                NhtbuilderNumber = string.Empty,
                ShowExteriorColorScheme = false,
                IsSecured = false,
            };
        }
        #endregion
    }


}
