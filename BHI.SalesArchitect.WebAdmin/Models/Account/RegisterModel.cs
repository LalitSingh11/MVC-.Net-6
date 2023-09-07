using System.ComponentModel.DataAnnotations;

namespace BHI.SalesArchitect.WebAdmin.Models.Account
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        //  [Required(ErrorMessage = "Phone Number field is required")]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^(\+?1-?)?(\([2-9]([02-9]\d|1[02-9])\)|[2-9]([02-9]\d|1[02-9]))-?[2-9]([02-9]\d|1[02-9])-?\d{4}$", ErrorMessage = "Please specify a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [RegularExpression(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$", ErrorMessage = "Email format is not valid")]
        public string Email { get; set; }
        public bool IsPartnerSuperAdmin { get; set; }
        public string AssociationIds { get; set; }
    }
}
