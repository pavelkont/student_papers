using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Pages
{
    [IgnoreAntiforgeryToken]
    public class ContactOwnerModel : PageModel
    {
        ApplicationDbContext context;
        [BindProperty]
        public Tech? Tech { get; set; }
        public ContactOwnerModel (ApplicationDbContext db)
        {
            context = db;
        }
        public List<Tipe> Tipes { get; private set; } = new();
        public List<Brand> Brands { get; private set; } = new();
        public List<Mark> Marks { get; private set; } = new();
        public List<Owner> Owners { get; private set; } = new();
        public List<AppUser> AppUsers { get; private set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Tipes = context.Tipes.AsNoTracking().ToList();
            Brands = context.Brands.AsNoTracking().ToList();
            Marks = context.Marks.AsNoTracking().ToList();
            Owners = context.Owners.AsNoTracking().ToList();
            AppUsers = context.AppUsers.AsNoTracking().ToList();
            Tech = await context.Techs.FindAsync(id);
            if (Tech == null) return NotFound();
            return Page();
        }
    }
}