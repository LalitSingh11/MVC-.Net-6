using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IProspectCommunityRepository
    {
        Task<bool> DeleteByUserId(int userId);
        Task<IEnumerable<ProspectCommunity>> GetByUserId(int userId);
    }
}
