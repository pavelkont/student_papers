using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Controllers
{
    public class RoleController : Controller
    {
        private RoleManager<Microsoft.AspNetCore.Identity.IdentityRole> roleManager;
        private UserManager<AppUser> userManager;
        public RoleController(RoleManager<Microsoft.AspNetCore.Identity.IdentityRole> roleMgr, UserManager<AppUser> userMgr)
        {
            roleManager = roleMgr;
            userManager = userMgr;
        }


        public ViewResult Index()
        {
            var roles = roleManager.Roles.ToList();
            var rolesWithUsers = new List<RoleWithUsers>();

            foreach (var role in roles)
            {
                // Получаем пользователей для каждой роли
                var usersInRole = userManager.GetUsersInRoleAsync(role.Name).Result;

                // Заполняем нашу вспомогательную модель
                rolesWithUsers.Add(new RoleWithUsers
                {
                    Role = role,
                    UserNames = usersInRole.Select(u => u.UserName).ToList()
                });
            }

            return View(rolesWithUsers); // Отправляем данные в представление
        }





        //public ViewResult Index() => View(roleManager.Roles);

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create([Required] string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(new Microsoft.AspNetCore.Identity.IdentityRole(name));
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            return View(name);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            Microsoft.AspNetCore.Identity.IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "No role found");
            return View("Index", roleManager.Roles);
        }

        public async Task<IActionResult> Update(string id)
        {
            // Получаем роль
            Microsoft.AspNetCore.Identity.IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound($"Role with ID {id} not found.");
            }

            // Загружаем всех пользователей и их роли одним запросом
            var users = userManager.Users.ToList();
            var userRoles = await userManager.GetUsersInRoleAsync(role.Name);

            // Разделяем пользователей на членов роли и не членов
            List<AppUser> members = userRoles.ToList();
            List<AppUser> nonMembers = users.Except(members).ToList();

            // Возвращаем результат
            return View(new RoleEdit
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            });
        }


        [HttpPost]
        public async Task<IActionResult> Update(RoleModification model)
        {
            IdentityResult result;
            if (ModelState.IsValid)
            {
                foreach (string userId in model.AddIds ?? new string[] { })
                {
                    AppUser user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                            Errors(result);
                    }
                }
                foreach (string userId in model.DeleteIds ?? new string[] { })
                {
                    AppUser user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                            Errors(result);
                    }
                }
            }

            if (ModelState.IsValid)
                return RedirectToAction(nameof(Index));
            else
                return await Update(model.RoleId);
        }
    }
}

/*        public async Task<IActionResult> Update(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();

            foreach (AppUser user in userManager.Users)
            {
                var list = await userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            return View(new RoleEdit
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            });
        }*/