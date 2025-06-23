using MimeKit;

namespace VKR_Kontorin.Models
{
    public class EmailHelper
    {
        public bool SendEmail(string userEmail, string confirmationLink)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Система Диспетчер", "vkr-kontorin@yandex.ru"));
            message.To.Add(new MailboxAddress("Получатель", userEmail));
            message.Subject = "Подтверждение email";
            message.Body = new BodyBuilder()
            {
                HtmlBody = $"Для подтверждения регистрации перейдите, пожалуйста, по ссылке: <a href='{confirmationLink}'>Подтвердить регистрацию</a>"
            }.ToMessageBody();

            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();            
            client.Connect("smtp.yandex.ru", 465, true);
            client.Authenticate("vkr-kontorin@yandex.ru", "qiarvidjyxuqehcx");
            client.Send(message);
            client.Disconnect(true);
            try
            {
                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Спам!");
            }
            return false;
        }
        public bool SendEmailPasswordReset(string userEmail, string link)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Система Диспетчер", "vkr-kontorin@yandex.ru"));
            message.To.Add(new MailboxAddress("Получатель", userEmail));
            message.Subject = "Сброс пароля";
            message.Body = new BodyBuilder()
            {
                HtmlBody = $"Для сброса пароля перейдите, пожалуйста, по ссылке: <a href='{link}'>Сброс пароля</a>"
            }.ToMessageBody();

            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();
            client.Connect("smtp.yandex.ru", 465, true); // 465 или 587
            client.Authenticate("vkr-kontorin@yandex.ru", "qiarvidjyxuqehcx");
            client.Send(message);
            client.Disconnect(true);
            try
            {
                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка отправки email: {ex.Message}");
                return false;
            }
        }
    }
}