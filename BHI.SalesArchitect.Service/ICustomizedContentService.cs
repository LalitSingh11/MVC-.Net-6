using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.Service
{
    public interface ICustomizedContentService
    {
        Task<IEnumerable<CustomizedContentResult>> GetByPartnerId(int partnerId);
        Task<IEnumerable<CustomizedContentResult>> GetByPartnerIdandCommId(int partnerId, int commId);

    }
}
