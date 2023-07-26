using BHI.SalesArchitect.Model;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class GeoJSON
    {
        public object LotData { get; set; }
        public object Amenities { get; set; }
        public object ViewModel { get; set; }
        public Community CommDetail { get; set; }
        public string SVGMapData { get; set; }
    }
    public enum GeoJsonType
    {
        Parcels = 1,
        Amenity = 2
    }
}