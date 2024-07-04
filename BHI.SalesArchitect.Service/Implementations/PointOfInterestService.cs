using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class PointOfInterestService : IPointOfInterestService
    {
        private IPointOfInterestRepository _pointOfInterestRepository;
        public PointOfInterestService(IPointOfInterestRepository pointOfInterestRepository)
        {
            _pointOfInterestRepository = pointOfInterestRepository;
        }
        public IEnumerable<PointOfInterest> GetAll()
        {
            return _pointOfInterestRepository.GetAll();
        }

        public async Task<IEnumerable<PointOfInterest>> GetByCommunityId(int commId, bool isGeospatial = false)
        {
            return await _pointOfInterestRepository.GetByCommunityId(commId, isGeospatial);
        }
    }
}
