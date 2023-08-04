using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class LotRepository : ILotRepository
    {
        private SalesArchitectContext _dbContext;
        public LotRepository(SalesArchitectContext db)
        {
            _dbContext = db;
        }

        public IEnumerable<Lot> GetByCommunityID(int? communityID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lot> GetByPartnerID(int? partnerID)
        {
            throw new NotImplementedException();
        }

        /*public IEnumerable<Lot> GetByCommunityID(int? communityID)
        {
            return _db.Lots.Where(x => x.communi == siteID).ToList();
        }*/

        /* public IEnumerable<Lot> GetByPartnerID(int? partnerID)
         {
             return _db.Lots.;
         }*/

        public IEnumerable<Lot> GetBySiteID(int? siteID)
        {
            var query = from l in _dbContext.Lots
                               join ls in _dbContext.LotStates on l.LotStateId equals ls.Id
                               where l.SiteId == siteID
                               select l;

            return query.ToList();
        }
    }
}
