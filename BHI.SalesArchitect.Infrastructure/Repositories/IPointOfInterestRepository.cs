using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IPointOfInterestRepository
    {
        IEnumerable<PointOfInterest> GetAll();
        Task<IEnumerable<PointOfInterest>> GetByCommunityId(int commId, bool isGeospatial = false);
    }
}
