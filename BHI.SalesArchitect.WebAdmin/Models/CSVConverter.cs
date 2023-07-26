using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

using System.Xml.Linq;




namespace BHI.SalesArchitect.WebAdmin.Models
{
  
    public class CSVConverter
    {
        [Display(Name = "Prospect Name")]
        public string ProspectName { get; set; }

        [Display(Name = "Community Name")]
        public string CommunityName { get; set; }

        [Display(Name = "Date of Visit")]
        public string DateOfVisit { get; set; }

        [Display(Name = "# of Favorites")]
        public int NoofFavorites { get; set; }


        public string Email { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }

  
}