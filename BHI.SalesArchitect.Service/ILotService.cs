using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ILotService
    {
        IEnumerable<Lot> GetByCommId(int commID);
        Lot GetByID(int lotId);
    }
}
