using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ILotService
    {
        Task<IEnumerable<Lot>> GetByCommId(int commID);
        Task<Lot> GetByID(int lotId);
        Task<bool> UpdateByLotStateId(int lotStateId);
        Task<IEnumerable<Lot>> GetByConfigId(int configId);        
        Task<bool> UpdateLot(Lot lot);
    }
}
