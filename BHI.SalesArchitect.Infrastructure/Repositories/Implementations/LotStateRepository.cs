using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class LotStateRepository : ILotStateRepository
    {
        private SalesArchitectContext _dbContext;
        private IActivityStateRepository _activityStateRepository;
        public LotStateRepository(SalesArchitectContext dbContext,
            IActivityStateRepository activityStateRepository)
        {
            _dbContext = dbContext;
            _activityStateRepository = activityStateRepository;
        }

        public async Task<bool> DeleteByConfigId(int configId)
        {
            var lotStateToDelete = from ls in _dbContext.LotStates
                                   join c in _dbContext.Configurations on new { ls.PartnerId, Name = ls.Code } equals new { c.PartnerId, c.Name }
                                   where configId == c.Id
                                   select ls;

            _dbContext.LotStates.Remove(lotStateToDelete.FirstOrDefault());
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<LotState>> GetByConfigId(int configId)
        {
            var result = from ls in _dbContext.LotStates
                         join c1 in _dbContext.Configurations on ls.PartnerId equals c1.PartnerId
                         join c2 in _dbContext.Configurations on ls.Code equals c2.Name
                         where c1.Id == configId && c2.Id == configId
                         select ls;
            return await result.ToListAsync();
        }

        public async Task<IEnumerable<LotState>> GetByPartnerId(int partnerId)
        {
            return await _dbContext.LotStates.Where(x => x.PartnerId == partnerId || x.PartnerId == null).ToListAsync();
        }
    }
}
