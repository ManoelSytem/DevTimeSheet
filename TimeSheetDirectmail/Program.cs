using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDirectmail.Controller;
using TimeSheetDirectmail.Model;
using TimeSheetDirectmail.Repository;

namespace TimeSheetDirectmail
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProtheusRepository repository = new ProtheusRepository();
            Controlle controlle = new Controlle(repository);
            var usuarios  =  controlle.ObterTecnicos(controlle.Login("tsadministrador", "123456"), "");
            Console.WriteLine("TimeSheet Envindo email de fechamento pendentes aguarde...");
            string mensagem = "";
            foreach (string mesg in controlle.Leitura())
            {
               mensagem += mesg;
            }
            foreach (Usuario usuario in usuarios)
            {
                controlle.EnviarEmail(usuario.Email, usuario.Nome, mensagem);
            }
            
        }
    }
}
