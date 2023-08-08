using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class BuilderBrandRepository : IBuilderBrandRepository
    {
        private SalesArchitectContext _dbContext;
        public BuilderBrandRepository(SalesArchitectContext db)
        {
            _dbContext = db;
        }
        public IEnumerable<BuilderBrand> GetByPartnerId(int partnerId)
        {
            var query = from bb in _dbContext.BuilderBrands
                        join pbb in _dbContext.PartnerBuilderBrands on bb.Id equals pbb.BuilderBrandId
                        where pbb.PartnerId == partnerId
                        select bb;
            return query.ToList();
        }
    }
}
