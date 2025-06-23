using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Pages
{
    [IgnoreAntiforgeryToken]
    public class EditTechCityModel : PageModel
    {
        ApplicationDbContext context;
        [BindProperty]
        public Tech? Tech { get; set; }
        public EditTechCityModel(ApplicationDbContext db)
        {
            context = db;
        }
        public List<Tipe> Tipes { get; private set; } = new();
        public List<Brand> Brands { get; private set; } = new();
        public List<Mark> Marks{ get; private set; } = new();
        public List<City> Cities { get; private set; } = new();
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Tipes = context.Tipes.AsNoTracking().ToList();
            Brands = context.Brands.AsNoTracking().ToList();
            Marks = context.Marks.AsNoTracking().ToList();
            Cities = context.Cities.AsNoTracking().ToList();
            Tech = await context.Techs.FindAsync(id);
            if (Tech == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Techs.Update(Tech!);
            await context.SaveChangesAsync();
            return RedirectToPage("ViewTechCity");
        }
    }
}