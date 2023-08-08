using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class BuilderBrandService : IBuilderBrandService
    {
        private IBuilderBrandRepository _builderBrandRepository;
        public BuilderBrandService(IBuilderBrandRepository builderBrandRepository)
        {
            _builderBrandRepository = builderBrandRepository;
        }

        public IEnumerable<BuilderBrand> GetByPartnerId(int partnerId)
        {
            return _builderBrandRepository.GetByPartnerId(partnerId).ToList();
            
        }
    }
}
