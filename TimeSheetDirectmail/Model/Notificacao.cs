using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetDirectmail.Model
{
    public class Notificacao
    {

        

        public void EnviarEmail(string email, string mensagem, string assunto)
        {
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp2.intranet.bahiagas.com.br",
                    Port = 25,
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                   
            };
                using (var message = new MailMessage("microsiga_getin@bahiagas.com.br", email) { Subject = assunto, Body = mensagem })
                {
                    message.IsBodyHtml = true;
                    smtp.Send(message);
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Não foi possível enviar email.", ex);
            }
        }

        
    }
}
