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

        public Fechamento CalcularLancamentoPorData(IOrderedEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho, Configuracao configura)
        {
            Fechamento Fechamento = new Fechamento();
            Fechamento.TotalHoraExedente = Math.Round(CalcularTotalHoraExedente(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            Fechamento.TotalAtraso = Math.Round(CalcularAtraso(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            Fechamento.TotalFalta = CalcularQuantidadeDeDiaSemApontamento(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho);
            Fechamento.TotalAbono = CalcularTotalDeAbono(orderedlistalancamento.OrderBy(c => c.DateLancamento), configura);
            Fechamento.TotalHora = Math.Round(CalcularTotalHoras(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            return Fechamento;

        }

        private int CalcularQuantidadeDeDiaSemApontamento(IOrderedEnumerable<Lancamento> orderedEnumerable, JornadaTrabalho jornadaTrabalho)
        {
            throw new NotImplementedException();
        }

        public double CalcularTotalHoraExedente(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
            TimeSpan totalHoraDiaLancamento = TimeSpan.Parse("00:00:00");
            TimeSpan totalLancamento;
            TimeSpan totalHoraExedenteTimeSpan;
            string datalancamento = "0";
            double totalHoraExedente;
            var jrDiaria = jornada.JornadaDiaria;

            foreach (Lancamento LancamentoResult in lancamentoList)
            {

                if (datalancamento != LancamentoResult.DateLancamento && datalancamento != "0")
                {
                    totalHoraDiaLancamento -= jrDiaria;
                }
                datalancamento = LancamentoResult.DateLancamento;
                totalLancamento = LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
            }

            totalHoraExedenteTimeSpan = jrDiaria - totalHoraDiaLancamento;
            totalHoraExedente = totalHoraExedenteTimeSpan.TotalHours;
            if (totalHoraExedenteTimeSpan > jrDiaria)
            {
                return totalHoraExedente;
            }
            else
            {
                return totalHoraExedente = 0;
            }
        }

        public int CalcularTotalDeAbono(IOrderedEnumerable<Lancamento> lancamentoList, Configuracao config)
        {
            int totalAbono = 0;
            foreach (Lancamento LancamentoResult in lancamentoList)
            {
                if (LancamentoResult.CodDivergencia == Convert.ToInt16(config.CodDivergencia))
                {
                    totalAbono++;
                }

            }
            return totalAbono;
        }

        public double CalcularAtraso(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
            TimeSpan TotalAtraso = TimeSpan.Parse("00:00:00");
            foreach (Lancamento LancamentoResult in lancamentoList)
            {
                if (LancamentoResult.HoraInicio > jornada.HoraInicioDe)
                {
                    TotalAtraso += LancamentoResult.HoraInicio - jornada.HoraInicioDe;
                }

            }
            return TotalAtraso.TotalHours;
        }

        public double CalcularTotalHoras(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
            TimeSpan TotalHoras = TimeSpan.Parse("00:00:00");
            foreach (Lancamento LancamentoResult in lancamentoList)
            {

                TotalHoras += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;

            }
            return TotalHoras.TotalHours;
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
    }
      
}
