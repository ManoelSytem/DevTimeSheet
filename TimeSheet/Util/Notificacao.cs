using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace TimeSheet.Util
{
    public class Notificacao : INotificacao
    {

        private readonly IConfiguration Configuration;

        public Notificacao(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void EnviarEmail(string email, string mensagem)
        {
            try
            {
                var smtp = new SmtpClient
                {
                    Host = Configuration.GetSection("EmailService")["Host"],
                    Port = Convert.ToInt32(Configuration.GetSection("EmailService")["Port"]),
                    EnableSsl = Convert.ToBoolean(Configuration.GetSection("EmailService")["Ssl"]),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                using (var message = new MailMessage(Configuration.GetSection("EmailService")["Email"], email) { Subject = "TimeSheet Fechamento de Marcações", Body = mensagem })
                {
                    smtp.Send(message);
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Não foi possível enviar email.", ex);
            }
        }

        public void EnviarEmail(IEnumerable<string> email, string mensagem)
        {
            throw new NotImplementedException();
        }
    }
}
