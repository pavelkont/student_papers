using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using VKR_Kontorin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Data.SqlClient;

namespace VKR_Kontorin.Pages
{
    public class WheeledExcavatorModel : PageModel
    {
        ApplicationDbContext context;
        public WheeledExcavatorModel(ApplicationDbContext db)
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
