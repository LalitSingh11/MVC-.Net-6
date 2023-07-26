using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "PlacesNearBySearch")]
    public class PlacesNearBySearch
    {
        [DataMember(Name = "business_status")]
        public string business_status { get; set; }
        [DataMember(Name = "geometry")]
        public Geometry geometry { get; set; }
        [DataMember(Name = "icon")]
        public string icon { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "opening_hours")]
        public Opening_Hours opening_hours { get; set; }
        [DataMember(Name = "photos")]
        public Photo[] photos { get; set; }
        [DataMember(Name = "place_id")]
        public string place_id { get; set; }
        [DataMember(Name = "plus_code")]
        public Plus_Code plus_code { get; set; }
        [DataMember(Name = "price_level")]
        public int price_level { get; set; }
        [DataMember(Name = "rating")]
        public float rating { get; set; }
        [DataMember(Name = "reference")]
        public string reference { get; set; }
        [DataMember(Name = "scope")]
        public string scope { get; set; }
        [DataMember(Name = "types")]
        public string[] types { get; set; }
        [DataMember(Name = "user_ratings_total")]
        public int user_ratings_total { get; set; }
        [DataMember(Name = "vicinity")]
        public string vicinity { get; set; }
        [DataMember(Name = "permanently_closed")]
        public bool permanently_closed { get; set; }
    }

    [DataContract(Name = "Opening_Hours")]
    public class Opening_Hours
    {
        [DataMember(Name = "open_now")]
        public bool open_now { get; set; }
    }

    [DataContract(Name = "Plus_Code")]
    public class Plus_Code
    {
        [DataMember(Name = "compound_code")]
        public string compound_code { get; set; }
        [DataMember(Name = "global_code")]
        public string global_code { get; set; }
    }

    [DataContract(Name = "Photo")]
    public class Photo
    {
        [DataMember(Name = "height")]
        public int height { get; set; }
        [DataMember(Name = "html_attributions")]
        public string[] html_attributions { get; set; }
        [DataMember(Name = "photo_reference")]
        public string photo_reference { get; set; }
        [DataMember(Name = "width")]
        public int width { get; set; }
    }
}