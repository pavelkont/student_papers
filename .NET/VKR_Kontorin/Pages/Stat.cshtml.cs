using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Pages
{
    [Authorize(Roles = "Owner")]
        public class StatModel : PageModel
    {
        ApplicationDbContext context;
        public StatModel(ApplicationDbContext db)
        {
            context = db;
        }
        public List<Stat> Stats { get; private set; } = new();
        public List<Tech> Techs { get; private set; } = new();
        public List<Tipe> Tipes { get; private set; } = new();
        public List<Brand> Brands { get; private set; } = new();
        public List<Mark> Marks { get; private set; } = new();
        public Tech? Tech { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Stats = context.Stats.AsNoTracking().ToList();
            Techs = context.Techs.AsNoTracking().ToList();
            Tipes = context.Tipes.AsNoTracking().ToList();
            Brands = context.Brands.AsNoTracking().ToList();
            Marks = context.Marks.AsNoTracking().ToList();
            Tech = await context.Techs.FindAsync(id);
            if (Tech == null) return NotFound();
            return Page();
        }
    }
}