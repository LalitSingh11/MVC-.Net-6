using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IProspectCommunityService
    {
        Task<bool> DeleteByUserId(int userId);
    }
}
