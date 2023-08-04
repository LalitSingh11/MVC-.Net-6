using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure
{
    public interface ISiteRepository
    {
        Site GetByIdWithoutSvg(int siteId);
    }
}
