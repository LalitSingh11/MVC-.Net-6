using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace BHI.SalesArchitect.WebAdmin.Controllers
{
    public class AccountController : Controller
    {

        public async Task<IActionResult> Login()
        {
            // Authenticate the user
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, "username"), // Replace "username" with the actual user's name
            // Add other claims if needed
        };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(principal);

            // Redirect to a secure page after successful login
            return RedirectToAction("Index", "Communities");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Redirect to a logout confirmation page or home page
            return RedirectToAction("Index", "Communities");
        }

    }
}
