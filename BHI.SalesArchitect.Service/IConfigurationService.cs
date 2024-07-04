using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IConfigurationService
    {
        Task<IEnumerable<Configuration>> GetIspConfigurationsByPartnerId(int partnerId);
        Task<bool> UpdatePopupTitlesConfiguration(Dictionary<string,string> popupTitlesDict, int partnerId);

        Task<bool> Delete(int id);
    }
}
