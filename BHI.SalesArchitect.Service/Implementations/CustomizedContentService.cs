using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class CustomizedContentService : ICustomizedContentService
    {
        public ICustomizedContentRepository _customizedContentRepository;
        public IProspectConfigurationRepository _prospectConfigurationRepository;
        public ICommunityConfigurationRepository _communityConfigurationRepository;
        public CustomizedContentService(ICustomizedContentRepository customizedContentRepository,
            IProspectConfigurationRepository prospectConfigurationRepository,
            ICommunityConfigurationRepository communityConfigurationRepository)
        {
            _customizedContentRepository = customizedContentRepository;
            _prospectConfigurationRepository = prospectConfigurationRepository;
            _communityConfigurationRepository = communityConfigurationRepository;
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

        public async Task<IEnumerable<CustomizedContentResult>> GetByPartnerIdAndCommId(int partnerId, int commId)
        {
            var customizedContent = await _customizedContentRepository.GetByPartnerIdAndCommId(partnerId, commId);
            var filteredContent = customizedContent
                .GroupBy(cc => cc.CustomizedContentTypeId)
                .Select(group => group.OrderByDescending(g => g.CommunityId)
                        .ThenByDescending(g => g.PartnerId).First())
                .ToList();

            return filteredContent;            
        }
    }
}
