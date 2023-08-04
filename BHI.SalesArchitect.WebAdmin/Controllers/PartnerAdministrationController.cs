using Microsoft.AspNetCore.Mvc;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    public class PartnerAdministrationController : BaseController
    {
        public PartnerAdministrationController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
