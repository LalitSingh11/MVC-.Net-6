using BHI.SalesArchitect.Model;
using System.Runtime.Serialization;

namespace BHI.SalesArchitect.WebAdmin.Models.WebApi
{
    [DataContract(Name = "DeleteEntityModal")]
    public class DeleteEntityModal : BaseEntity
    {
        [DataMember(Name = "EntityName")]
        public string EntityName { get; set; }
    }
}