namespace VKR_Kontorin.Models
{
    public class RoleEdit
    {
        public Microsoft.AspNetCore.Identity.IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}