using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CustomizedContentService : ICustomizedContentService
    {
        public ICustomizedContentRepository _customizedContentRepository;
        public CustomizedContentService(ICustomizedContentRepository customizedContentRepository)
        {
            _customizedContentRepository = customizedContentRepository;
        }

        public async Task<IEnumerable<CustomizedContentResult>> GetByPartnerId(int partnerId)
        {
            var customizedContent =  await _customizedContentRepository.GetByPartnerId(partnerId);
            var filteredContent = customizedContent
                .GroupBy(cc => cc.CustomizedContentTypeId)
                .Select(group => group.OrderByDescending(g => g.PartnerId).First())
                //.GroupBy(fc => fc.LocationCode).SelectMany(x => x)
                .ToList();

            
            return filteredContent;
        }

        public async Task<IEnumerable<CustomizedContentResult>> GetByPartnerIdandCommId(int partnerId, int commId)
        {
            var customizedContent = await _customizedContentRepository.GetByPartnerIdandCommId(partnerId, commId);
            var filteredContent = customizedContent
                .GroupBy(cc => cc.CustomizedContentTypeId)
                .Select(group => group.OrderByDescending(g => g.CommunityId)
                        .ThenByDescending(g => g.PartnerId).First())
                .ToList();
            return filteredContent;            
        }
    }
}
