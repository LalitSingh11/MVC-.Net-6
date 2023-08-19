using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class LotStateService : ILotStateService
    {
        private ILotStateRepository _lotStateRepository;
        public LotStateService(ILotStateRepository lotStateRepository)
        {
            _lotStateRepository = lotStateRepository;
        }
        public IEnumerable<LotState> GetByPartnerId(int partnerId)
        {
            return _lotStateRepository.GetByPartnerId(partnerId);
        }
    }
}
