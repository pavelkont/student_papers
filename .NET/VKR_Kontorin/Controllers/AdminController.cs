using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;
        private IPasswordHasher<AppUser> passwordHasher;
        public AdminController(UserManager<AppUser> usrMgr, IPasswordHasher<AppUser> passwordHash, ApplicationDbContext db)
        {
            userManager = usrMgr;
            passwordHasher = passwordHash;
            context = db;
        }
        ApplicationDbContext context;
        public List<Tech> Techs { get; private set; } = new();
        public List<Owner> Owners { get; private set; } = new();
        public List<AppUser> AppUsers { get; private set; } = new();

        // Create:
        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = user.Name,
                    Email = user.Email,
                    PhoneNumberConfirmed = user.Owner
                };
                IdentityResult result = await userManager.CreateAsync(appUser, user.Password);
                string name = "";
                if (user.Owner == true) name = "Owner";
                else name = "User";
                AppUser userRole = await userManager.FindByNameAsync(user.Name);
                IdentityResult resultRole = await userManager.AddToRoleAsync(userRole, name);
                if (result.Succeeded)
                {
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(appUser);
                    var confirmationLink = Url.Action("ConfirmEmail", "Email", new { token, email = user.Email }, Request.Scheme);
                    EmailHelper emailHelper = new EmailHelper();
                    bool emailResponse = emailHelper.SendEmail(user.Email, confirmationLink);
                    return RedirectToPage("/CreateConfirmation");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }
        [AllowAnonymous]
        public IActionResult CreateConfirmation()
        {
            return View();
        }

        // Read:
        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        // Update:
        public async Task<IActionResult> Update(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
                return View(user);
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, string email, string password)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.Email = email;
                else
                    ModelState.AddModelError("", "Адрес электронной почты не может быть пустым");

                if (!string.IsNullOrEmpty(password))
                    user.PasswordHash = passwordHasher.HashPassword(user, password);
                else
                    ModelState.AddModelError("", "Пароль не может быть пустым");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "Пользователь на найден");
            return View(user);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        // Delete:
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            Owners = context.Owners.AsNoTracking().ToList();
            Techs = context.Techs.AsNoTracking().ToList();
            AppUsers = context.AppUsers.AsNoTracking().ToList();
            string tlfOwner = "";
            foreach (var a in AppUsers)
                if (a.Id == id)
                { tlfOwner = a.UserName; }
            int idOwner = 0;
            foreach (var o in Owners)
                if (o.Tlf == tlfOwner)
                { idOwner = o.Id; }
            foreach (var t in Techs)
                if (t.Owner_id == idOwner)
                {
                    var tech = await context.Techs.FindAsync(t.Id);
                    context.Techs.Remove(tech);
                    await context.SaveChangesAsync();
                }
            if (idOwner != 0)
            {
                var owner = await context.Owners.FindAsync(idOwner);
                context.Owners.Remove(owner);
                await context.SaveChangesAsync();
            }

            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "Пользователь не существует.");

            return View("Index", userManager.Users);            
        }
    }
}