using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VKR_Kontorin.Models;
using MimeKit;

namespace VKR_Kontorin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult SendEmail(string tlf, string tech, string email)
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Система Диспетчер", "vkr-kontorin@yandex.ru"));
                message.To.Add(new MailboxAddress("Получатель", email));
                message.Subject = "Бронирование техники";
                message.Body = new BodyBuilder() { HtmlBody = 
                    "<div style=\"color: red;\">Ваша техника забронирована:</div>" + @tech + "</br></br>" + "Номер заказчика: "  + @tlf 
                }.ToMessageBody();
                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.yandex.ru", 465, true);
                    client.Authenticate("vkr-kontorin@yandex.ru", "qiarvidjyxuqehcx");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.GetBaseException().Message);
            }
            return RedirectToPage("/Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index1()
        {
            return View();
        }
    }
}
