using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain.Enty;

namespace TimeSheet.ViewModel
{
    public class ViewModelLancamento
    {
        public int Codigo { get; set; }
        public DateTime DateLancamento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public int codEmpredimento { get; set; }
        public string DescricaoEmp { get; set; }
        public string Observacao { get; set; }
        public int CodObservacao { get; set; }
        public int CodDivergencia { get; set; }
        public int CodMarcacaoa { get; set; }
        public string[] EmpreendimentoIds { get; set; }
        public virtual ICollection<Empreendimento> Empreendimentos { get; set; }

    }
}
