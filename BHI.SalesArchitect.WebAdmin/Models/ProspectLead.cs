using BHI.SalesArchitect.WebAdmin.Lib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class ProspectLead
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(30, ErrorMessage = "First name must not exceed 30 characters.")]
        //[RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Invalid characters in First Name.")]
        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "Last name must not exceed 30 characters.")]
        //[RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Invalid characters in last name.")]
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "Email address is required.")]
        [RegularExpression(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$", ErrorMessage = "Email format is not valid.")]
        public string EmailAddress { get; set; }
        [StringLength(10, ErrorMessage = "Invalid phone number.", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }
        [StringLength(7, ErrorMessage = "Invalid zip code.",MinimumLength =5)]
        [RequiredIf("IsZipCodeRequired",true,ErrorMessage="Zip code is required.")]
        public string ZipCode { get; set; }
        [StringLength(1000, ErrorMessage = "Comments must not exceed 1000 characters.")]
        public string Comments { get; set; }
        public int CommunityID { get; set; }
        public int partnerID { get; set; }
        public bool IsZipCodeRequired { get; set; }
        public int platform { get; set; }
    }

    public class HolALotRequest
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(30, ErrorMessage = "First name must not exceed 30 characters.")]
        //[RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Invalid characters in First Name.")]
        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "Last name must not exceed 30 characters.")]
        //[RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Invalid characters in last name.")]
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "Email address is required.")]
        [RegularExpression(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$", ErrorMessage = "Email format is not valid.")]
        public string EmailAddress { get; set; }
        [StringLength(10, ErrorMessage = "Invalid phone number.", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid phone number.")]
        [Required(ErrorMessage = "Phone Number is required.")]
        public string PhoneNumber { get; set; }
        [StringLength(7, ErrorMessage = "Invalid zip code.", MinimumLength = 5)]
        [RequiredIf("IsZipCodeRequired", true, ErrorMessage = "Zip code is required.")]
        public string ZipCode { get; set; }
        [StringLength(1000, ErrorMessage = "Comments must not exceed 1000 characters.")]
        public string Comments { get; set; }
        public int CommunityID { get; set; }
        public int partnerID { get; set; }
        public bool IsZipCodeRequired { get; set; }
        public int platform { get; set; }
    }
}