using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VKR_Kontorin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace VKR_Kontorin.Pages
{
    [Authorize]
    public class IndexAuthorizeModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        ApplicationDbContext context;

        public IndexAuthorizeModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            context = db;
        }
        public List<Tech> Techs { get; private set; } = new();
        public List<Owner> Owners { get; private set; } = new();
        public List<AppUser> AppUsers { get; private set; } = new();
        public List<Message> Messages { get; private set; } = new();
        public void OnGet()
        {
            Techs = context.Techs.AsNoTracking().ToList();
            Owners = context.Owners.AsNoTracking().ToList();
            AppUsers = context.AppUsers.AsNoTracking().ToList();
            Messages = context.Messages.AsNoTracking().ToList();
        }
        [BindProperty]
        public Message Message { get; set; } = new();
        public async Task<IActionResult> OnPostAsync()
        {
            context.Messages.Add(Message);
            await context.SaveChangesAsync();
            return RedirectToPage("IndexAuthorize");
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var message = await context.Messages.FindAsync(id);
            if (message != null)
            {
                context.Messages.Remove(message);
                await context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}