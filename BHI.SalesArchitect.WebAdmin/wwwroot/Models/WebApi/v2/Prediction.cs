using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "Prediction")]
    /// <summary>
    /// Commented Code is not used in Model as requested by Mobile Developers
    /// They only need 4 fields in prediction
    /// </summary>
    public class Prediction
    {
        [DataMember(Name = "Description")]
        public string Description { get; set; }
        [DataMember(Name = "DistanceMeters")]
        public int DistanceMeters { get; set; }
        [DataMember(Name = "Id")]
        public string Id { get; set; }
        [DataMember(Name = "PlaceId")]
        public string PlaceId { get; set; }
        //public string reference { get; set; }
        //public List<Term> terms { get; set; }
        //public List<string> types { get; set; }
        //public Structured_Formatting structured_formatting { get; set; }
    }

    //public class Structured_Formatting
    //{
    //    public string main_text { get; set; }
    //    public List<Main_Text_Matched_Substrings> main_text_matched_substrings { get; set; }
    //    public string secondary_text { get; set; }
    //}

    //public class Main_Text_Matched_Substrings
    //{
    //    public int length { get; set; }
    //    public int offset { get; set; }
    //}

    //public class Matched_Substrings
    //{
    //    public int length { get; set; }
    //    public int offset { get; set; }
    //}

    //public class Term
    //{
    //    public int offset { get; set; }
    //    public string value { get; set; }
    //}
}