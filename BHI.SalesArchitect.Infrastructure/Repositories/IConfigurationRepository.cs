using BHI.SalesArchitect.Model.DB;
using static BHI.SalesArchitect.Core.Enumerations.CommonEnumerations;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IConfigurationRepository
    {
        Task<IEnumerable<Configuration>> GetByPartnerId(int partnerId, int assetType = (int)AssetTypes.HEXCOL);
        Task<IEnumerable<Configuration>> GetIspDefaultConfigurations();
        Task<IEnumerable<Configuration>> GetIspConfigurationsByPartnerId(int partnerId);
        Task<IEnumerable<Configuration>> GetCommDefaultConfigurations();
        Task<bool> DeleteIspConfigByPartnerId(int partnerId);
        Task<bool> Delete(int id);
        Task<bool> AddIspConfigByPartnerId(List<Configuration> popupConfigurations);
    }
}
