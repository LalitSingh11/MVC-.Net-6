using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
/// <summary>
/// BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
/// </summary>
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi.Sync
{
    [DataContract(Name="CommunityVersion")]
    /// <summary>
    /// CummunityVersion
    /// </summary>
    public class CummunityVersion
    {
        [DataMember(Name ="CommunityID")]
        /// <summary>
        /// CommunityID
        /// </summary>
        public int CommunityID { get; set; }
        [DataMember(Name = "DBVersion")]
        /// <summary>
        /// DBVersion
        /// </summary>
        public int DBVersion { get; set; }
        [DataMember(Name = "BDXCommunityID")]
        /// <summary>
        /// DBVersion
        /// </summary>
        public int BDXCommunityID { get; set; }
    }
}
