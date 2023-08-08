using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service
{
    public interface IBuilderBrandService
    {
        IEnumerable<BuilderBrand> GetByPartnerId(int partnerId);
    }
}
