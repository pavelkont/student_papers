using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VKR_Kontorin.Models
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Tech> Techs { get; set; } = null!;
        public DbSet<Tipe> Tipes { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Mark> Marks { get; set; } = null!;
        public DbSet<Owner> Owners { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<AppUser> AppUsers { get; set; } = null!;
        public DbSet<AppRole> AppRoles { get; set; } = null!;
        public DbSet<Stat> Stats { get; set; } = null!;
        public DbSet<Message> Messages { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}