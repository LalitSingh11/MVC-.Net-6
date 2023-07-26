using System.Runtime.Serialization;
namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "PublicResponsePackage")]
    public class PublicResponsePackage
    {
        [DataMember(Name = "ErrorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class PublicResponsePackage<T> : PublicResponsePackage
    {
        [DataMember(Name = "Model")]
        public T Model { get; set; }
    }
}