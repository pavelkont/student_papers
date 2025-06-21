using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateConfirmationModel : PageModel
    {
        ApplicationDbContext context;
        [BindProperty]
        public Owner Owner { get; set; } = new();
        public CreateConfirmationModel(ApplicationDbContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Owners.Add(Owner);
            await context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
        public List<Owner> Owners { get; private set; } = new();
        public List<AppUser> AppUsers { get; private set; } = new();

        public void OnGet()
        {
            Owners = context.Owners.AsNoTracking().ToList();
            AppUsers= context.AppUsers.AsNoTracking().ToList();
        }


    }
}
