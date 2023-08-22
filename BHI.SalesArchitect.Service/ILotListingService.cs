using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ILotListingService
    {
        IEnumerable<LotListing> GetByLotId(int lotId);
        Task<bool> UpdateLotListings(List<LotListing> lotListings, int lotId);

        //Task<bool> AddLotListings(List<LotListing> lotListings);
    }
}
