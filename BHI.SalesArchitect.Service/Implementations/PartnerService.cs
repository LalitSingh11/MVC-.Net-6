using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class PartnerService : IPartnerService
    {
        private IPartnerRepository _partnerRepository;
        public PartnerService(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        public IEnumerable<Partner> GetAllPartners(int[] type, int partnerStatusType)
        {
            var partners = _partnerRepository.GetAll(type);
            if (partnerStatusType == 0)
            {
                partners = partners.Where(x => x.Status == true).ToList();
            }
            else if (partnerStatusType == 1)
            {
                partners = partners.Where(x => x.Status == false).ToList();
            }
            return partners;
        }

        public Partner GetById(int id)
        {
            return _partnerRepository.GetById(id);
        }        
    }
}
