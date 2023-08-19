using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class LotService : ILotService
    {
        private readonly ILotRepository _lotRepository;
        public LotService(ILotRepository lotRepository)
        {
            _lotRepository = lotRepository;
        }
        public IEnumerable<Lot> GetByCommId(int commId)
        {
            return _lotRepository.GetByCommunityID(commId);
        }

        public Lot GetByID(int lotId)
        {
            var a =  _lotRepository.GetByID(lotId);
            return a;
        }
    }
}
