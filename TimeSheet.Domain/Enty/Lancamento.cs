using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty
{
    public class Lancamento
    {
        public string Codigo { get; set; }
        public string Seq { get; set; }
        public string CodLancamento { get; set; }
        public string DateLancamento { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFim { get; set; }
        public string codEmpredimento { get; set; }
        public string DescricaoEmp { get; set; }
        public string Observacao { get; set; }
        public int CodObservacao { get; set; }
        public int CodDivergencia { get; set; }
        public string[] EmpreendimentoIds { get; set; }
        public virtual ICollection<Empreendimento> Projetos { get; set; }


        public void ValidaHorasLancamentoOutraMarcacao(List<Lancamento> listlancamentoRelizado)
        {
            foreach (Lancamento LancamentoResult in listlancamentoRelizado)
            {
                if (LancamentoResult.Seq != this.Seq)
                {
                    if (!(this.HoraInicio >= LancamentoResult.HoraFim || this.HoraInicio <= LancamentoResult.HoraInicio && this.HoraFim <= LancamentoResult.HoraInicio))
                        throw new Exception("Não pode existir horas sobrepostas para o mesmo dia.");
                }
            }

        }

    }
    public class LancamentoDb
    {
        public string Codigo { get; set; }
        public string Seq { get; set; }
        public string CodLancamento { get; set; }
        public string DateLancamento { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public string codEmpredimento { get; set; }
        public string DescricaoEmp { get; set; }
        public string Observacao { get; set; }
        public int CodObservacao { get; set; }
        public int CodDivergencia { get; set; }
        public string[] EmpreendimentoIds { get; set; }
        public virtual ICollection<Empreendimento> Projetos { get; set; }
    }
      
}
