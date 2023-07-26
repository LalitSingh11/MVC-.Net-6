using BHI.SalesArchitect.Model;
using BHI.SalesArchitect.WebAdmin.Models.WebApi.Base;
using BHI.SalesArchitect.WebAdmin.Models.WebApi.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "Consumer")]
    public class Consumer : ConsumerBase
    {
        
        [DataMember(Name = "IsActive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [DataMember(Name = "LastLogin")]
        public DateTime LastLogin { get; set; }

        [DataMember(Name = "AccessKey")]
        public string AccessKey { get; set; }
        
        [DataMember(Name = "RequestType")]
        public int RequestType { get; set; }

        [DataMember(Name = "ProspectID")]
        public int ProspectID { get; set; }
        
        public Consumer()
        {

        }

    }
}