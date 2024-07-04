using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.Service
{
    public interface ICustomizedContentService
    {
        Task<IEnumerable<CustomizedContentResult>> GetByPartnerId(int partnerId);
        Task<IEnumerable<CustomizedContentResult>> GetByPartnerIdAndCommId(int partnerId, int commId);

    }
}
