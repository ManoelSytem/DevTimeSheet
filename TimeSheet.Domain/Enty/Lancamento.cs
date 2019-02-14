using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSheet.Domain.Enty
{
    public class Lancamento
    {
        public string Codigo { get; set; }
        public string Seq { get; set; }
        public string CodLancamento { get; set; }
        public string DateLancamento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string codEmpredimento { get; set; }
        public string DescricaoEmp { get; set; }
        public string Observacao { get; set; }
        public int CodObservacao { get; set; }
        public int CodDivergencia { get; set; }
        public string Status { get; set; }
        public string[] EmpreendimentoIds { get; set; }
        public virtual ICollection<Empreendimento> Projetos { get; set; }
        public string Fase { get; set; }


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

        public List<Fechamento> CalcularLancamentoPorData(IOrderedEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho, Configuracao configura)
        {
            List<Fechamento> listaFechamentoPorData = new List<Fechamento>();
          

            listaFechamentoPorData = CalcularTotalHoraExedenteETrabalhada(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho,configura);
            return listaFechamentoPorData;
        }

        public List<Fechamento> CalcularTotalHoraExedenteETrabalhada(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada, Configuracao config)
        {
           
            List<Fechamento> listFechamentoHorasExedentes = new List<Fechamento>();
            TimeSpan totalHoraDiaLancamento = TimeSpan.Parse("00:00:00");
            TimeSpan totalLancamento = TimeSpan.Parse("00:00:00");
            string datalancamento = "0";
            double totalAbono = 0;
            var jrDiaria = jornada.JornadaDiaria;

            foreach (Lancamento LancamentoResult in lancamentoList)
            {
                
                if (datalancamento != LancamentoResult.DateLancamento && datalancamento != "0")
                {
                    Fechamento novo = new Fechamento();
                    if (totalLancamento > jrDiaria)
                    {
                        novo.TotalHora = Math.Round(Convert.ToDouble(totalLancamento.TotalHours), 2);
                        novo.DataLancamento = LancamentoResult.DateLancamento;
                        totalLancamento = totalLancamento - jrDiaria;
                        if(Eabono(LancamentoResult,config)) novo.TotalAbono = totalAbono;
                        novo.TotalHoraExedente = Math.Round(Convert.ToDouble(totalLancamento.TotalHours),2);
                        listFechamentoHorasExedentes.Add(novo);
                        totalLancamento = TimeSpan.Parse("00:00:00");
                        totalAbono = 0;
                    }
                    else  {
                        novo.TotalHoraExedente = 0;
                        novo.TotalAtraso = Math.Round(Convert.ToDouble(totalLancamento.TotalHours), 2);
                        novo.DataLancamento = LancamentoResult.DateLancamento;
                        if(Eabono(LancamentoResult, config))novo.TotalAbono = totalAbono;
                        novo.TotalHora = Math.Round(Convert.ToDouble(totalLancamento.TotalHours), 2);
                        listFechamentoHorasExedentes.Add(novo);
                        totalAbono = 0;
                    }
                   
                }
                datalancamento = LancamentoResult.DateLancamento;
                totalLancamento += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
                totalAbono += CalcularTotaAbono(LancamentoResult, config);
            }

            return listFechamentoHorasExedentes;
        }

        private double CalcularTotaAbono(Lancamento lancamento, Configuracao config)
        {
            int totalAbono = 0;

            if (lancamento.HoraInicio != TimeSpan.Parse("00:00:00") && lancamento.CodDivergencia != 0)
            {
                totalAbono++;
            }
            return totalAbono;
        }

        private bool Eabono(Lancamento lancamento, Configuracao config)
        {
            if (lancamento.HoraInicio != TimeSpan.Parse("00:00:00") && lancamento.CodDivergencia != 0)
            {
                return true;
            }
            else
            {
                return false;
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
        public string Status { get; set; }
        public string[] EmpreendimentoIds { get; set; }
        public virtual ICollection<Empreendimento> Projetos { get; set; }
        public string Fase { get; set; }
        public string CodigoProjeto { get; set; }
    }
      
}
