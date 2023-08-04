using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IPartnerRepository
    {
        Partner GetById(int id);
    }
}
