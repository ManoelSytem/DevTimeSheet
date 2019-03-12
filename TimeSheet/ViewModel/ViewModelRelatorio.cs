using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain.Enty;

namespace TimeSheet.ViewModel
{
    public class ViewModelRelatorio
    {
        public ViewModelFechamento Fechamento { get; set;}
        public List<ViewModelFechamento> FechamentoPorDatalancamento { get; set; }
        public List<Apontamento> apontamento { get; set; }
        public ViewModelMacacao marcacao { get; set; }
        public Usuario user { get; set; }
        public string status { get; set; }
        public double totalGeral { get; set; }
        public double totalExcedente { get; set; }
        public double totalAbono { get; set; }
        public double totalNaoTrabalhada{ get; set; }
    }
}
