using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class SiteService : ISiteService
    {
        private ISiteRepository _siteRepository;
        public SiteService(ISiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }

        public Site GetByIdWithoutSvg(int siteId)
        {
            return _siteRepository.GetByIdWithoutSvg(siteId);
        }
    }
}
