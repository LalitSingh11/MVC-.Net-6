using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "PlacesDetail")]
    public class PlacesDetail
    {
        [DataMember(Name = "AddressComponents")]
        public List<Address_Components> AddressComponents { get; set; }
        [DataMember(Name = "AdrAddress")]
        public string AdrAddress { get; set; }
        [DataMember(Name = "FormattedAddress")]
        public string FormattedAddress { get; set; }
        [DataMember(Name = "FormattedPhoneNumber")]
        public string FormattedPhoneNumber { get; set; }
        [DataMember(Name = "Geometry")]
        public Geometry Geometry { get; set; }
        [DataMember(Name = "Icon")]
        public string Icon { get; set; }
        [DataMember(Name = "Id")]
        public string Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "PlaceId")]
        public string PlaceId { get; set; }
        [DataMember(Name = "InternationalPhoneNumber")]
        public string InternationalPhoneNumber { get; set; }
        [DataMember(Name = "Rating")]
        public float Rating { get; set; }
        [DataMember(Name = "Reference")]
        public string Reference { get; set; }
        [DataMember(Name = "Reviews")]
        public List<Review> Reviews { get; set; }
        [DataMember(Name = "Types")]
        public List<string> Types { get; set; }
        [DataMember(Name = "URL")]
        public string URL { get; set; }
        [DataMember(Name = "UTCOffSet")]
        public int UTCOffSet { get; set; }
        [DataMember(Name = "Vicinity")]
        public string Vicinity { get; set; }
        [DataMember(Name = "Website")]
        public string Website { get; set; }
        [DataMember(Name = "Photos")]
        public List<Photo> Photos { get; set; }
    }

    [DataContract(Name = "Geometry")]
    public class Geometry
    {
        [DataMember(Name = "Location")]
        public Location Location { get; set; }
        [DataMember(Name = "Viewport")]
        public Viewport Viewport { get; set; }
    }

    [DataContract(Name = "Location")]
    public class Location
    {
        [DataMember(Name = "Lat")]
        public float Lat { get; set; }
        [DataMember(Name = "Lng")]
        public float Lng { get; set; }
    }
    [DataContract(Name = "Viewport")]
    public class Viewport
    {
        [DataMember(Name = "Northeast")]
        public Location Northeast { get; set; }
        [DataMember(Name = "Southwest")]
        public Location Southwest { get; set; }
    }

    [DataContract(Name = "Address_Components")]
    public class Address_Components
    {
        [DataMember(Name = "LongName")]
        public string LongName { get; set; }
        [DataMember(Name = "ShortName")]
        public string ShortName { get; set; }
        [DataMember(Name = "Types")]
        public List<string> Types { get; set; }
    }
    [DataContract(Name = "Review")]
    public class Review
    {
        [DataMember(Name = "AuthorName")]
        public string AuthorName { get; set; }
        [DataMember(Name = "AuthorURL")]
        public string AuthorURL { get; set; }
        [DataMember(Name = "Language")]
        public string Language { get; set; }
        [DataMember(Name = "ProfilePhotoUrl")]
        public string ProfilePhotoUrl { get; set; }
        [DataMember(Name = "Rating")]
        public int Rating { get; set; }
        [DataMember(Name = "RelativeTimeDescription")]
        public string RelativeTimeDescription { get; set; }
        [DataMember(Name = "Text")]
        public string Text { get; set; }
        [DataMember(Name = "Time")]
        public int Time { get; set; }
    }

}