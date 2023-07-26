using BHI.SalesArchitect.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public class ProspectViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(30, ErrorMessage = "First name must not exceed 30 characters.")]
        //[RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Special characters and blank spaces are not allowed in First Name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(30, ErrorMessage = "Last name must not exceed 30 characters.")]
        //[RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Special characters and blank spaces are not allowed in Last Name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$", ErrorMessage = "Email format is not valid")]
        public string Email { get; set; }
        [RegularExpression(@"^(\+?1-?)?(\([2-9]([02-9]\d|1[02-9])\)|[2-9]([02-9]\d|1[02-9]))-?[2-9]([02-9]\d|1[02-9])-?\d{4}$", ErrorMessage = "Please specify a valid phone number")]
        public string Phone { get; set; }
        [StringLength(7, ErrorMessage = "Invalid zip code.", MinimumLength = 5)]
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string CardNumber { get; set; }
        public string AccessKey { get; set; }
        public int PartnerID { get; set; }
        public string UID { get; set; }
        public List<ReferralSources> ReferralSources { get; set; }
        public List<Community> Communities { get; set; }
        public string JsonReferralSource { get; set; }
        public string JsonCommunities { get; set; }
        public int Platform { get; set; }
    }
}