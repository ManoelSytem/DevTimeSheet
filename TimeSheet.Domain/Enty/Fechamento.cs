using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSheet.Domain.Enty
{
    public class Fechamento
    {
        public string Filial{ get; set; }
        public string CodigoMarcacao { get; set; }
        public string HoraFechamento { get; set; }
        public double TotalHoraExedente { get; set; }
        public double TotalAtraso { get; set; }
        public double TotalFalta { get; set; }
        public double TotalAbono { get; set; }
        public double TotalHora { get; set; }

        public string DataLancamento { get; set; }
        public string Descricao { get; set; }
        public string Divergencia { get; set; }

        public List<Fechamento> ValidarFechamento(List<Marcacao> marcacao, List<Apontamento> apontamentos, JornadaTrabalho jornada)
        {
            List<Fechamento> listFechamento = new List<Fechamento>();

            return listFechamento;
        }

        public Fechamento CalcularFechamento(IOrderedEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho)
        {
            Fechamento Fechamento = new Fechamento();
            Fechamento.TotalHoraExedente = CalcularTotalHoraExedente(orderedlistalancamento, jornadaTrabalho);
            return Fechamento;
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

                if (datalancamento != LancamentoResult.DateLancamento && datalancamento != "0") {
                    totalHoraDiaLancamento -= jrDiaria;
                }
                datalancamento = LancamentoResult.DateLancamento;
                totalLancamento = LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
                totalHoraDiaLancamento += totalLancamento;
                
            }

            totalHoraExedenteTimeSpan = totalHoraDiaLancamento;
            totalHoraExedente = totalHoraExedenteTimeSpan.TotalHours;

            return totalHoraExedente;
        }

       
    }
}
