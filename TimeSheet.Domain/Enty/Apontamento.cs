using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty
{
    public class Apontamento
    {
        public string hora { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFim { get; set; }
        public TimeSpan apontamento { get; set; }
        public string dataApontamento { get; set; }
        public List<Lancamento> listLancamento { get; set; }
        
    }
}
