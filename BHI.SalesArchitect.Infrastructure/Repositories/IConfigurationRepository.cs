using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IConfigurationRepository
    {
        Task<IEnumerable<Configuration>> GetIspDefaultConfigurations();
        Task<IEnumerable<Configuration>> GetIspConfigurationsByPartnerId(int partnerId);
        Task<bool> DeleteIspConfigByPartnerId(int partnerId);
        Task<bool> AddIspConfigByPartnerId(List<Configuration> popupConfigurations);
    }
}
