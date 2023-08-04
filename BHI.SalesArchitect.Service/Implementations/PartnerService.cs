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
        public Partner GetById(int id)
        {
            return _partnerRepository.GetById(id);
        }        
    }
}
