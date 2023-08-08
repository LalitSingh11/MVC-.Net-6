using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class PartnerRepository : IPartnerRepository
    {
        private SalesArchitectContext _dbContext;
        public PartnerRepository(SalesArchitectContext dbContext)
        {

            _dbContext = dbContext;

        }

        public IEnumerable<Partner> GetAll(int[] type)
        {
            return _dbContext.Partners.Where(x => type.Contains(x.Type));
        }

        public Partner GetById(int id)
        {
            return _dbContext.Partners.Find(id);
        }
    }
}
