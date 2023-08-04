using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface ISiteService
    {
        Site GetByIdWithoutSvg(int siteId);
    }
}
