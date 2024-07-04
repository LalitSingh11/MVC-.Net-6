using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IPointOfInterestService
    {
        IEnumerable<PointOfInterest> GetAll();
        Task<IEnumerable<PointOfInterest>> GetByCommunityId(int commId, bool isGeospatial = false);
    }
}
