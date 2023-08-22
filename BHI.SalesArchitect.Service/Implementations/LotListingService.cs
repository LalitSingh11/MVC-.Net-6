using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class LotListingService : ILotListingService
    {
        private ILotListingRepository _lotListingRepository;
        public LotListingService(ILotListingRepository lotListingRepository) 
        {
            _lotListingRepository = lotListingRepository;
        }

        public IEnumerable<LotListing> GetByLotId(int lotId)
        {
            return _lotListingRepository.GetByLotId(lotId);
        }

        public async Task<bool> UpdateLotListings(List<LotListing> lotListings, int lotId)
        {
            await _lotListingRepository.DeleteLotListingsByLotId(lotId);
            return await _lotListingRepository.AddLotListings(lotListings);
        }
    }
}
