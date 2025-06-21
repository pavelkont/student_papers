using Microsoft.AspNetCore.Identity;

namespace VKR_Kontorin.Models
{
    public class RoleWithUsers
    {
        public Microsoft.AspNetCore.Identity.IdentityRole Role { get; set; }
        public List<string> UserNames { get; set; }
    }

}
