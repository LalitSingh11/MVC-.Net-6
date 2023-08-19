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

        public IEnumerable<Lot> GetByPartnerID(int partnerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lot> GetBySiteID(int siteId)
        {
            var query = from l in _dbContext.Lots
                               join ls in _dbContext.LotStates on l.LotStateId equals ls.Id
                               where l.SiteId == siteId
                               select l;

            return query.ToList();
        }
        public IEnumerable<Lot> GetByCommunityID(int commId)
        {
            var query = from l in _dbContext.Lots
                        join ls in _dbContext.LotStates on l.LotStateId equals ls.Id
                        join cs in _dbContext.CommunitySites on l.SiteId equals cs.SiteId
                        where cs.CommunityId == commId
                        select l;

            return query.ToList();
        }

        public Lot GetByID(int lotId)
        {
            return _dbContext.Lots.FirstOrDefault(x => x.Id == lotId);
        }
    }
}
