using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "EditProfilePackage")]
    public class EditProfilePackage
    {
        [DataMember(Name = "ImageAssetFile")]
        public HttpPostedFileBase ImageAssetFile { get; set; }

        /// <summary>
        /// A json object is expected for prospect
        /// </summary>
        public string Data { get; set; }
    }
}