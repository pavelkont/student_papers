using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Pages
{
    [Authorize(Roles = "Admin")]
    [IgnoreAntiforgeryToken]
    public class EditBlockModel : PageModel
    {
        ApplicationDbContext context;
        [BindProperty]
        public Tech? Tech { get; set; }       
        public EditBlockModel(ApplicationDbContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Tech = await context.Techs.FindAsync(id);
            if (Tech == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string url)
        {
            context.Techs.Update(Tech!);
            await context.SaveChangesAsync();
            return RedirectToPage(url);
        }
    }
}