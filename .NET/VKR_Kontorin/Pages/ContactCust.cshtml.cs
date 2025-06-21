using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Pages
{
    [IgnoreAntiforgeryToken]
    public class ContactCustModel : PageModel
    {
        ApplicationDbContext context;
        [BindProperty]
        public Tech? Tech { get; set; }
        public ContactCustModel (ApplicationDbContext db)
        {
            context = db;
        }
        public List<Owner> Owners { get; private set; } = new();
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Owners = context.Owners.AsNoTracking().ToList();
            Tech = await context.Techs.FindAsync(id);
            if (Tech == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Techs.Update(Tech!);
            await context.SaveChangesAsync();
            return Page();
            //return RedirectToPage("ContactOwner");
        }
    }
}