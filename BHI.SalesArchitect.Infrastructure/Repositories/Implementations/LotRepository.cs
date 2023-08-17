using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class LotRepository : ILotRepository
    {
        private SalesArchitectContext _dbContext;
        public LotRepository(SalesArchitectContext db)
        {
            _dbContext = db;
        }

        public IEnumerable<Lot> GetByPartnerID(int? partnerID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lot> GetBySiteID(int? siteID)
        {
            var query = from l in _dbContext.Lots
                               join ls in _dbContext.LotStates on l.LotStateId equals ls.Id
                               where l.SiteId == siteID
                               select l;

            return query.ToList();
        }
        public IEnumerable<Lot> GetByCommunityID(int? commID)
        {
            var query = from l in _dbContext.Lots
                        join ls in _dbContext.LotStates on l.LotStateId equals ls.Id
                        join cs in _dbContext.CommunitySites on l.SiteId equals cs.SiteId
                        where cs.CommunityId == commID
                        select l;

            return query.ToList();
        }

    }
}
