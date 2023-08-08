using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IPartnerService
    {
        Partner GetById(int id);
        IEnumerable<Partner> GetAllPartners(int[] type, int partnerStatusType);
    }
}
