using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class MasterPlanRepository : IMasterPlanRepository
    {
        private SalesArchitectContext _dbContext;
        public MasterPlanRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MasterPlan GetByIdWithoutSvg(int masterSiteID)
        {
            var query = _dbContext.MasterPlans
                 .Where(m => m.Id == masterSiteID)
                 .Select(m => new MasterPlan
                 {
                     Id = m.Id,
                     MapImage = m.MapImage,
                     Name = m.Name,
                     ImageUpdate =  m.ImageUpdate,
                     PdfImage = m.PdfImage,
                     IsMasterGeoSvg = m.IsMasterGeoSvg,
                     GeospatialMapImage = m.GeospatialMapImage,
                     GeospatialPdfImage = m.GeospatialPdfImage
                 })
                 .FirstOrDefault();
            return query;
        }
    }
}
