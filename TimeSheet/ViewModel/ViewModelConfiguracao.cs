using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.ViewModel
{
    public class ViewModelConfiguracao
    {
        public int Codigo { get; set; }
        public int DiaMesLimiteFecha { get; set; }
        public int Frequencia_email { get; set; }
        public int Qtddiadatafechamento { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public string AssuntoEmail { get; set; }
        public string TextoEmail { get; set; }
        public int CodDivergencia { get; set; }
        public  List<CodDivergencia> ListCodDivergencia { get; set; }

      
        public ViewModelConfiguracao()
        {
            
        }


    }


    public class CodDivergencia
    {
        public int codigo { get; set; }
        public string Descricao { get; set; }
    }
}
