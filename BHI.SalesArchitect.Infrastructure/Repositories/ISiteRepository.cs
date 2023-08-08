using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ISiteRepository
    {
        Site GetByIdWithoutSvg(int siteId);
    }
}
