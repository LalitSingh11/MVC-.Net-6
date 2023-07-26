using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.WebAdmin.Models.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.v2
{
    [DataContract(Name = "LoginRequest")]
    public class LoginRequest : ConsumerBase
    {
        /// <summary>
        /// (To avoid these fields to be shown on APi Explorer, But these are internally used in the application)
        /// </summary>
        #region Non Data member fields 
        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastLogin { get; set; }

        public string AccessKey { get; set; }

        public int RequestType { get; set; }

        public int ProspectID { get; set; }
        #endregion

        [DataMember(Name = "CommunityCode")]
        public string CommunityCode { get; set; }
        [DataMember(Name = "IsBuilderBrandedApplication")]
        public bool IsBuilderBrandedApplication { get; set; }
        [DataMember(Name = "Source")]
        public int Source { get; set; }
        [DataMember(Name = "includeMPC")]
        public bool includeMPC { get; set; }
    }

    [DataContract(Name = "UUPLoginRequest")]
    public class UUPLoginRequest : ConsumerBase
    {
        /// <summary>
        /// (To avoid these fields to be shown on APi Explorer, But these are internally used in the application)
        /// </summary>
        #region Non Data member fields 
        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastLogin { get; set; }

        public string AccessKey { get; set; }

        public int RequestType { get; set; }

        public int ProspectID { get; set; }

        #endregion
        [DataMember(Name = "Platform")]
        public int Platform { get; set; }
        [DataMember(Name = "CommunityCode")]
        public string CommunityCode { get; set; }
        [DataMember(Name = "IsBuilderBrandedApplication")]
        public bool IsBuilderBrandedApplication { get; set; }
        [DataMember(Name = "Source")]
        public int Source { get; set; }
        [DataMember(Name = "includeMPC")]
        public bool includeMPC { get; set; }

        [DataMember(Name = "UUPAccessToken")]
        public string UUPAccessToken { get; set; }
        [DataMember(Name = "OrgID")]
        public int OrgID { get; set; }
    }
}