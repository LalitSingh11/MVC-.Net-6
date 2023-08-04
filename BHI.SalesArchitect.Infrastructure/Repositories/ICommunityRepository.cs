using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICommunityRepository
    {
        IEnumerable<GridCommunityResult> GetProcDataByPartnerId(int partnerID);
        IEnumerable<Community> GetByCommunityIDs(List<int> communityIDs);

    }
}
