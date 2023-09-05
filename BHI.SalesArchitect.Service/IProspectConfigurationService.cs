using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IProspectConfigurationService
    {
        Task<ProspectConfiguration> GetByPartnerId(int  partnerId);
        Task<bool> SaveProspectConfiguration(int partnerId, int userId, ProspectConfiguration prospectConfiguration);
        Task<bool> SaveIspPartnerConfiguration(int partnerId, int userId, ProspectConfiguration prospectConfiguration);
        Task<bool> SaveHoldALotConfiguration(int partnerId, int userId, ProspectConfiguration prospectConfiguration);
        Task<bool> SavePdfConfiguration(int partnerId, int userId, ProspectConfiguration prospectConfiguration);
    }
}
