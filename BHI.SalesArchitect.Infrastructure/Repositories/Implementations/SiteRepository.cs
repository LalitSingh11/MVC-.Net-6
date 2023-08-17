using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class SiteRepository : ISiteRepository
    {
        private SalesArchitectContext _dbContext;
        public SiteRepository(SalesArchitectContext db)
        {
            _dbContext = db;
        }
        public Site GetByIdWithoutSvg(int siteId)
        {
            var query = _dbContext.Sites.Where(x => x.Id == siteId)
                .Select(s => new Site
                {
                    Id = s.Id,
                    MapImage = s.MapImage,
                    Name = s.Name,
                    ImageUpdate = s.ImageUpdate,
                    PdfImage = s.PdfImage,
                    GeospatialPluginImage = s.GeospatialPluginImage,
                    GeospatialPluginPdfImage = s.GeospatialPluginPdfImage,
                    IsGeoSvg = s.IsGeoSvg
                })
                .FirstOrDefault();
            return query;
        }
    }
}
