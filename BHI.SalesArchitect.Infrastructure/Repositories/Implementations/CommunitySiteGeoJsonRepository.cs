using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CommunitySiteGeoJsonRepository : ICommunitySiteGeoJsonRepository
    {
        private readonly SalesArchitectContext _dbContext;
        public CommunitySiteGeoJsonRepository(SalesArchitectContext db)
        {
            _dbContext = db;
        }

        public IEnumerable<CommunitySiteGeoJson> GetByCommunityIds(List<int> communityIds)
        {
            return _dbContext.CommunitySiteGeoJsons.Where(x => communityIds.Contains(x.Id) && x.ActivityStateId == 1).ToList();
        }
    }
}
