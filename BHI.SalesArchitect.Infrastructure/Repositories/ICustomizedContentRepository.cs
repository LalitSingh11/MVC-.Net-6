using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface ICustomizedContentRepository
    {
        Task<IEnumerable<CustomizedContentResult>> GetByPartnerId(int partnerId);
        Task<IEnumerable<CustomizedContentResult>> GetByPartnerIdAndCommId(int partnerId, int commId);
    }
}
