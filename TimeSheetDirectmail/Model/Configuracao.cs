using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetDirectmail.Model
{
   public  class Configuracao
    {
        public string Codigo { get; set; }
        public string FilialProtheus { get; set; }
        public string MatriculaUsuario { get; set; }
        public int DiaMesLimiteFecha { get; set; }
        public int Frequencia_email { get; set; }
        public string AssuntoEmail { get; set; }
        public string TextoEmail { get; set; }
        public int Qtddiadatafechamento { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public string CodDivergencia { get; set; }


        public bool ValidaDataEnvioEmail()
        {
            DateTime dataInicioEnvioEmail = new DateTime(DateTime.Now.Year, DateTime.Now.Month, this.Qtddiadatafechamento);
            DateTime dataFimFechamento = new DateTime(DateTime.Now.Year, DateTime.Now.Month+1, this.DiaMesLimiteFecha);

            if(DateTime.Now >= dataInicioEnvioEmail && DateTime.Now <= dataFimFechamento)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
