using System.Net;
using System.Net.Mail;

namespace DamelasCook.Services;

    public interface EmailSender ; IEmailSender
    {
        public async Task SenEmailAsync(string EmailAddress, string subject, string htmlMessage)
        {
            var mail = "gcook.app@outlook.com";
            var pw = "QV3E4khpZBEcL7K";

            var client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                EnableSsl = true;
                Credentials =  new NetworkCredential(mail, pw)
            };
            MailMessage sendMail = new
        }
        
    }
