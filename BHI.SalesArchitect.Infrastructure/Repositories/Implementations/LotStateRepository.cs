using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class LotStateRepository : ILotStateRepository
    {
        private SalesArchitectContext _dbContext;
        public LotStateRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public IEnumerable<LotState> GetByPartnerId(int partnerId)
        {
            return _dbContext.LotStates.Where(x => x.PartnerId == partnerId || x.PartnerId == null);
        }
    }
}
