using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSheet.Domain.Util;

namespace TimeSheet.Domain.Enty
{
    public class Fechamento
    {
        public string Filial { get; set; }
        public string CodigoMarcacao { get; set; }
        public string HoraFechamento { get; set; }
        public double TotalHoraExedente { get; set; }
        public double TotalAtraso { get; set; }
        public double TotalFalta { get; set; }
        public double TotalAbono { get; set; }
        public double TotalHora { get; set; }
        public string DataLancamento { get; set; }
        public string Datafechamento { get; set; }
        public string Descricao { get; set; }
        public string Divergencia { get; set; }
        public string StatusFechamento { get; set; }
        public string CodigoProjeto { get; set; }
        public string Fase { get; set; }
        public double TotalFaltaAtraso { get; set; }

        public Fechamento()
        {

        }

    }

}

