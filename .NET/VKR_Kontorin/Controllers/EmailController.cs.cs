using VKR_Kontorin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace VKR_Kontorin.Controllers
{
    public class EmailController : Controller
    {
        private UserManager<AppUser> userManager;
        public EmailController(UserManager<AppUser> usrMgr)
        {
            userManager = usrMgr;
        }

        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
                return View("Error");
            var result = await userManager.ConfirmEmailAsync(user, token);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }
    }
}