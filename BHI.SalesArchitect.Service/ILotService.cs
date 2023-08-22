using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ILotService
    {
        IEnumerable<Lot> GetByCommId(int commID);
        Task<Lot> GetByID(int lotId);
        
        Task<bool> UpdateLot(Lot lot);
    }
}
