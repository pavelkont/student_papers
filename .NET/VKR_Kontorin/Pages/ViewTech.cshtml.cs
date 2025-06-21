using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Identity;

namespace VKR_Kontorin.Pages
{
    [Authorize(Roles = "Owner")]
    public class ViewTechModel : PageModel
    {
        ApplicationDbContext context;
        public ViewTechModel(ApplicationDbContext db)
        {
            context = db;
        }
        public List<Tech> Techs { get; private set; } = new();
        public List<Tipe> Tipes { get; private set; } = new();
        public List<Brand> Brands { get; private set; } = new();
        public List<Mark> Marks { get; private set; } = new();
        public List<Owner> Owners { get; private set; } = new();
        public List<City> Cities { get; private set; } = new();
        public List<Stat> Stats { get; private set; } = new();
        public List<Message> Messages { get; private set; } = new();

        public void OnGet()
        {
            Techs = context.Techs.AsNoTracking().ToList();
            Tipes = context.Tipes.AsNoTracking().ToList();
            Brands = context.Brands.AsNoTracking().ToList();
            Marks = context.Marks.AsNoTracking().ToList();
            Owners = context.Owners.AsNoTracking().ToList();
            Cities = context.Cities.AsNoTracking().ToList();
            Stats = context.Stats.AsNoTracking().ToList();
            Messages = context.Messages.AsNoTracking().ToList();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var tech = await context.Techs.FindAsync(id);
            if (tech != null)
            {
                context.Techs.Remove(tech);
                await context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}
