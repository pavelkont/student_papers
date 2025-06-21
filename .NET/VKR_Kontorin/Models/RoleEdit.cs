using Microsoft.AspNetCore.Identity;
using VKR_Kontorin.Models;

namespace VKR_Kontorin.Models
{
    public class RoleEdit
    {
        public Microsoft.AspNetCore.Identity.IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}