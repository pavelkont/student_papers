using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Pages
{
    public class DumpTruckModel : PageModel
    {
        ApplicationDbContext context;
        public DumpTruckModel(ApplicationDbContext db)
        {
            context = db;
        }
        public List<Tech> Techs { get; private set; } = new();
        public List<Tipe> Tipes { get; private set; } = new();
        public List<Brand> Brands { get; private set; } = new();
        public List<Mark> Marks { get; private set; } = new();
        public List<Owner> Owners { get; private set; } = new();
        public List<City> Cities { get; private set; } = new();

        public void OnGet()
        {
            Techs = context.Techs.AsNoTracking().ToList();
            Tipes = context.Tipes.AsNoTracking().ToList();
            Brands = context.Brands.AsNoTracking().ToList();
            Marks = context.Marks.AsNoTracking().ToList();
            Owners = context.Owners.AsNoTracking().ToList();
            Cities = context.Cities.AsNoTracking().ToList();
        }
    }
}
