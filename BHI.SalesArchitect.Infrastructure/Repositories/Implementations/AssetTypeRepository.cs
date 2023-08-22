using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories.Implementations
{
    public class AssetTypeRepository : IAssetTypeRepository
    {
        private SalesArchitectContext _dbContext;
        public AssetTypeRepository(SalesArchitectContext dbContext)
        {
            _dbContext = dbContext;
        }
        public AssetType GifType { get; private set; }
        public AssetType JpgType { get; private set; }
        public AssetType TextType { get; private set; }
        public AssetType XmlType { get; private set; }
        public AssetType HexColorType { get; private set; }

        public IEnumerable<AssetType> GetAll()
        {
            return _dbContext.AssetTypes.ToList();
        }

        private void Initialization()
        {
            var assetTypes = GetAll();

            GifType = assetTypes.FirstOrDefault(p => p.Code == "GIF");
            JpgType = assetTypes.FirstOrDefault(p => p.Code == "JPG");
            TextType = assetTypes.FirstOrDefault(p => p.Code == "TEXT");
            XmlType = assetTypes.FirstOrDefault(p => p.Code == "XML");
            HexColorType = assetTypes.FirstOrDefault(p => p.Code == "HEXCOL");
        }
    }
}
