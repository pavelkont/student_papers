using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//using SendingEmail;
using System.Diagnostics;
using VKR_Kontorin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace VKR_Kontorin.Controllers
{
    /*[Authorize]*/
    public class StatisticController : Controller
    {
/*        private readonly ApplicationDbContext _dbcontext;
        private readonly IConfiguration _configuration;

        public StatisticController(ApplicationDbContext context, IConfiguration configuration)
        {
            _dbcontext = context;
            _configuration = configuration;
        }*/
/*        public IActionResult Index()
        {
            return View();
        }

        ApplicationDbContext context;
        IConfiguration configuration;

        public StatisticController(ApplicationDbContext db, IConfiguration configuration)
        {
            context = db;
            configuration = configuration;
        }

        public List<Stat> Stats { get; private set; } = new();
        public List<Tech> Techs { get; private set; } = new();
        public void OnGet()
        {
            Stats = context.Stats.AsNoTracking().ToList();
            Techs = context.Techs.AsNoTracking().ToList();
        }
        //[HttpPost]
        public List<object> GetQty()
        {
            List<object> data = new List<object>();
            List<string> labels = context.Stats.Select(m => m.Date).ToList();
            List<int> total = context.Stats.Select(t => t.Qty).ToList();
            data.Add(labels);
            data.Add(total);
            return data;
        }*/
        /*        private UserManager<AppUser> userManager;
                public StatisticController(UserManager<AppUser> userMgr)
                {
                    userManager = userMgr;
                }
                public IActionResult Index()
                {
                    return View();
                }

                public IActionResult About()
                {
                    return View();
                }

                [Authorize]
                public async Task<IActionResult> Secured()
                {
                    AppUser user = await userManager.GetUserAsync(HttpContext.User);
                    string message = "Hello " + user.UserName;
                    return View((object)message);
                }
                public IActionResult Error()
                {
                    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
                }*/
    }
}