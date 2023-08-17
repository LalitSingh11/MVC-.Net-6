using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ILotService
    {
        IEnumerable<Lot> GetByCommID(int? commID);
    }
}
