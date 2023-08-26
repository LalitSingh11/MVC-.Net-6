using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class CustomizedContentRepository : ICustomizedContentRepository
    {
        private SalesArchitectContext _dbContext;
        public CustomizedContentRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IEnumerable<CustomizedContentResult>> GetByPartnerId(int partnerId)
        {
            var customizedContent = from cc in _dbContext.CustomizedContents
                                join cct in _dbContext.CustomizedContentTypes on cc.CustomizedContentTypeId equals cct.Id
                                join cl in _dbContext.CustomizedLocations on cct.CustomizedLocationId equals cl.Id
                                where (cc.PartnerId == partnerId || cc.PartnerId == null)
                                && cc.CommunityId == null
                                select new CustomizedContentResult
                                {
                                    Id = cc.Id,
                                    LocationDescription = cl.Description,
                                    ContentType = cct.ContentType,
                                    PartnerId = cc.PartnerId,
                                    CommunityId = cc.CommunityId,
                                    CustomizedContentTypeId = cc.CustomizedContentTypeId,
                                    Value = cc.Value,
                                    LocationCode = cl.LocationCode
                                };        

            return await customizedContent.ToListAsync();
        }

        public async Task<IEnumerable<CustomizedContentResult>> GetByPartnerIdandCommId(int partnerId, int commId)
        {

            var customizedContent = from cc in _dbContext.CustomizedContents
                                    join cct in _dbContext.CustomizedContentTypes on cc.CustomizedContentTypeId equals cct.Id
                                    join cl in _dbContext.CustomizedLocations on cct.CustomizedLocationId equals cl.Id
                                    where (cc.PartnerId == partnerId || cc.PartnerId == null)
                                    && (cc.CommunityId == commId || cc.CommunityId == null)
                                    select new CustomizedContentResult
                                    {
                                        Id = cc.Id,
                                        LocationDescription = cl.Description,
                                        ContentType = cct.ContentType,
                                        PartnerId = cc.PartnerId,
                                        CommunityId = cc.CommunityId,
                                        CustomizedContentTypeId = cc.CustomizedContentTypeId,
                                        Value = cc.Value
                                    };            

            return await customizedContent.ToListAsync();
        }
    }   
}
