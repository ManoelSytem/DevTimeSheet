using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDirectmail.Controller;
using TimeSheetDirectmail.Repository;

namespace TimeSheetDirectmail
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProtheusRepository repository = new ProtheusRepository();
            Controlle novo = new Controlle(repository);
            novo.EnviarEmail();
            Console.WriteLine("TimeSheet Envindo em de fechamento pendentes aguarde...");
            Console.ReadKey();
        }
    }
}
