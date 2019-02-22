using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Util;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.ViewModel
{
    public class ViewModelFechamento
    {
        public string CodigoMarcacao { get; set; }
        public string DataLancamento { get; set; }
        public string Datafechamento { get; set; }
        public string Descricao { get; set; }
        public string Divergencia { get; set; }
        public double TotalHoraExedente { get; set; }
        public double TotalAtraso { get; set; }
        public double TotalFalta { get; set; }
        public double TotalAbono { get; set; }
        public double TotalHora { get; set; }
        public double TotalFaltaAtraso{ get; set; }

        public ViewModelFechamento()
        {
                
        }

        
        
    }
}
