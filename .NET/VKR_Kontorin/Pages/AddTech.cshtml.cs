using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;
using Microsoft.AspNetCore.Authorization;

namespace VKR_Kontorin.Pages
{
    [Authorize(Roles = "Admin, Owner")]
    [IgnoreAntiforgeryToken]
    public class AddTechModel : PageModel
    {
        ApplicationDbContext context;
        [BindProperty]
        public Tech Tech { get; set; } = new();
        public int id;
        public AddTechModel(ApplicationDbContext db)
        {
            context = db;
        }
        public List<Owner> Owners { get; private set; } = new();
        public async Task<IActionResult> OnPostAsync()
        {            
            context.Techs.Add(Tech);
            await context.SaveChangesAsync();
            return RedirectToPage("ViewTech");
        }
        public void OnGet()
        {
            Owners = context.Owners.AsNoTracking().ToList();
        }
    }
}

