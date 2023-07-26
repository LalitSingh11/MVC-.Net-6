using System.Runtime.Serialization;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "ProspectInsertPackage")]
    public class ProspectInsertPackage : InsertPackage
    {
        [DataMember(Name = "AccessKey")]
        public string AccessKey { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }

    }
}