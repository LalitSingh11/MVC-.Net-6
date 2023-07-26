using BHI.SalesArchitect.WebAdmin.Models.WebApi.v2;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "BasePackage")]
    public class BasePackage
    {
        public BasePackage()
        {
            Error = false;
            ErrorMessage = string.Empty;
            Code = 200;
        }
        [DataMember(Name = "Error")]
        public bool Error { get; set; }
        [DataMember(Name = "ErrorMessage")]
        public string ErrorMessage { get; set; }
        [DataMember(Name = "Code")]
        public int Code { get; set; }
        [DataMember(Name = "UniqueKey")]
        public string UniqueKey { get; set; }
    }

    public class BasePackage<T> : BasePackage
    {
        [DataMember(Name = "Model")]
        public T Model { get; set; }
        [DataMember(Name = "Entity")]
        public string Entity { get; set; }
    }

    public class BaseCountPackage<T> : BasePackage
    {
        [DataMember(Name = "Model")]
        public T Model { get; set; }
        [DataMember(Name = "TotalCount")]
        public int TotalCount { get; set; }
    }

    public class ConsumerBasePackage<T> : BasePackage
    {
        [DataMember(Name = "Model")]
        public T Model { get; set; }
        [DataMember(Name = "IsAlreadyRegistered")]
        public bool IsAlreadyRegistered { get; set; }
    }

    public class AssetDelete : BasePackage
    {
        [DataMember(Name = "invalidAssetIDs")]
        public List<int> invalidAssetIDs { get; set; }
        [DataMember(Name = "CDPSyncResponse")]
        public SyncIdentityResponse CDPSyncResponse { get; set; }
    }

    public class CommunityPackage<T> : BasePackage
    {
        [DataMember(Name = "Model")]
        public T Model { get; set; }
        [DataMember(Name = "Entity")]
        public string Entity { get; set; }
        [DataMember(Name = "CommunityCount")]
        public int CommunityCount { get; set; }
    }
    public class BaseCommunityCountPackage<T> : BasePackage
    {
        [DataMember(Name = "Model")]
        public T Model { get; set; }
        [DataMember(Name = "TotalCount")]
        public int TotalCount { get; set; }
        [DataMember(Name = "TotalHomeCount")]
        public int TotalHomeCount { get; set; }
        [DataMember(Name = "BDXBuilderIds")]
        public List<int> BDXBuilderIds { get; set; }
    }

    public class CDPBasePackage : BasePackage
    {
        [DataMember(Name = "CDPSyncResponse")]
        public SyncIdentityResponse CDPSyncResponse { get; set; }
    }
}