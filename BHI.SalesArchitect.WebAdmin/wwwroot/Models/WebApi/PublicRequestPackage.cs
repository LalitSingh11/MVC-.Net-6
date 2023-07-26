using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "PublicRequestPackage")]
    public class PublicRequestPackage
    {
        [DataMember(Name = "ClientKey")]
        public string ClientKey { get; set; }
    }

    public class PublicRequestPackage<T> : PublicRequestPackage
    {
        [DataMember(Name = "Model")]
        public T Model { get; set; }
    }

    public class PublicScalarRequestPackage<T> : PublicRequestPackage
    {
        [DataMember(Name = "ID")]
        public T ID { get; set; }
    }
}