using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Infrastructure.Repositories
{
    public interface IAssetTypeRepository
    {
        IEnumerable<AssetType> GetAll();    
        AssetType GifType { get; }
        AssetType JpgType { get; }
        AssetType TextType { get; }
        AssetType XmlType { get; }
        AssetType HexColorType { get; }
    }
}
