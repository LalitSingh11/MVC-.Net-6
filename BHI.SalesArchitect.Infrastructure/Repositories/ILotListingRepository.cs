using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ILotListingRepository
    {
        IEnumerable<LotListing> GetByLotId(int lotId);
        Task<bool> DeleteLotListingsByLotId(int lotId);
        Task<bool> AddLotListings(List<LotListing> lotListings);
    }
}
