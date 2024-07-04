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
        public async Task<IEnumerable<Lot>> GetByCommId(int commId)
        {
            return await _lotRepository.GetByCommunityID(commId);
        }

        public async Task<IEnumerable<Lot>> GetByConfigId(int configId)
        {
            return await _lotRepository.GetByConfigId(configId);
        }

        public async Task<Lot> GetByID(int lotId)
        {
            var lot = await _lotRepository.GetByID(lotId);
            //lot.ImagePath = GetLotImagePath(lot.Id);
            return lot;
        }

        public async Task<bool> UpdateByLotStateId(int lotStateId)
        {
            return await _lotRepository.UpdateByLotStateId(lotStateId);
        }

        public async Task<bool> UpdateLot(Lot lot)
        {
            Lot l = await GetByID(lot.Id);
            l.LotStateId = lot.LotStateId;
            l.Size = lot.Size;
            l.Block = lot.Block;
            l.Phase = lot.Phase;
            l.Description = lot.Description;
            l.Address = lot.Address;
            l.Elevation = lot.Elevation;
            l.Swing = lot.Swing;
            l.PremiumPrice = lot.PremiumPrice;
            l.ExternalReference = lot.ExternalReference;
            l.ContactLink = lot.ContactLink;
            l.ButtonText = lot.ButtonText;
            l.IsAmenity = lot.IsAmenity;
            l.DisplayName = lot.DisplayName;
            l.VideoUrl = lot.VideoUrl;
            l.ReservationFee = lot.ReservationFee;
            l.LotDescription = lot.LotDescription;
            //l.ImagePath
            return await _lotRepository.UpdateLot(l);
        }
    }
}

