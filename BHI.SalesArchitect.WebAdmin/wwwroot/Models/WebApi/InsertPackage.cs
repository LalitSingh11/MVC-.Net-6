using BHI.SalesArchitect.WebAdmin.Models.WebApi.v2;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name ="InsertPackage")]
    public class InsertPackage : BasePackage
    {
        [DataMember(Name ="RecordID")]
        public int RecordID { get; set; }
        [DataMember(Name = "Entity")]
        public string Entity { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }
        [DataMember(Name = "CDPSyncResponse")]
        public SyncIdentityResponse CDPSyncResponse { get; set; }
    }

    [DataContract(Name = "InsertPackage")]
    public class InsertPackage<T> : BasePackage
    {
        [DataMember(Name = "RecordID")]
        public int RecordID { get; set; }
        [DataMember(Name = "Entity")]
        public string Entity { get; set; }
        [DataMember(Name = "UID")]
        public string UID { get; set; }
        [DataMember(Name = "Model")]
        public T Model { get; set; }
    }
}