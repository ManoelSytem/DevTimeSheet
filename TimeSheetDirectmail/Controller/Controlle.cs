using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDirectmail.Model;
using TimeSheetDirectmail.Repository;

namespace TimeSheetDirectmail.Controller
{
    public class Controlle
    {
        private ProtheusRepository _repositoryProthues;
       
        public Controlle(ProtheusRepository repositoryProthues)
        {
            _repositoryProthues = repositoryProthues;
        }


        public void EnviarEmail()
        {
          
           Notificacao notificacao = new Notificacao();
           Configuracao config = new Configuracao();
           config  =  _repositoryProthues.ObterConfiguracao();
           notificacao.EnviarEmail("manoelcontatosi@gmail.com", "Prezado, teste envio e-mail", config.AssuntoEmail);

            if (config.ValidaDataEnvioEmail())
            {
               if(config.Frequencia_email == 1)
                {
                    notificacao.EnviarEmail("manoelcontatosi@gmail.com" , "Prezado, teste envio e-mail", config.AssuntoEmail);
                }
                else
                { 
                    if(config.Qtddiadatafechamento == DateTime.Now.Day | DateTime.Now.DayOfWeek == DayOfWeek.Sunday
                    &&
                    DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                    {
                        notificacao.EnviarEmail("manoelcontatosi@gmail.com", "Prezado, teste envio e-mail", config.AssuntoEmail);
                    }
                }

            }    
           
        }
    }


}
