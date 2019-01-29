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
        public int TotalFalta { get; set; }
        public double TotalAbono { get; set; }
        public double TotalHora { get; set; }
        public string DataLancamento { get; set; }
        public string Descricao { get; set; }
        public string Divergencia { get; set; }


        public Fechamento()
        {

        }

        public List<Fechamento> ValidarFechamento(List<Marcacao> marcacao, List<Apontamento> apontamentos, JornadaTrabalho jornada)
        {
            List<Fechamento> listFechamento = new List<Fechamento>();

            return listFechamento;
        }

        public Fechamento CalcularFechamento(IOrderedEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho)
        {
            Fechamento Fechamento = new Fechamento();
            Fechamento.TotalHoraExedente = Math.Round(CalcularTotalHoraExedente(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            Fechamento.TotalAtraso = Math.Round(CalcularAtraso(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            Fechamento.TotalFalta = CalcularQuantidadeDeDiaSemApontamento(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho);
            Fechamento.TotalAbono = CalcularTotalDeAbono(orderedlistalancamento.OrderBy(c => c.DateLancamento));
            Fechamento.TotalHora = Math.Round(CalcularTotalHoras(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
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

                if (datalancamento != LancamentoResult.DateLancamento && datalancamento != "0")
                {
                    totalHoraDiaLancamento -= jrDiaria;
                }
                datalancamento = LancamentoResult.DateLancamento;
                totalLancamento = LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
                totalHoraDiaLancamento += totalLancamento;

            }

            totalHoraExedenteTimeSpan = totalHoraDiaLancamento - jrDiaria;
            totalHoraExedente = totalHoraExedenteTimeSpan.TotalHours;

            return totalHoraExedente;
        }

        public int CalcularQuantidadeDeDiaSemApontamento(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
            DateTime initialDate = jornada.DataInicio;
            DateTime finalDate = jornada.DataFim;
            string datalancamento = "0";
            int countDiasDiasDiferenteLancamento = 0;
            int countDiasInguasLancamento = 0;

            var days = 0;
            var daysCount = 0;
            days = initialDate.Subtract(finalDate).Days;

            if (days < 0)
                days = days * -1;

            for (int i = 1; i <= days; i++)
            {
                initialDate = initialDate.AddDays(1);

                if (initialDate.DayOfWeek != DayOfWeek.Sunday
                     &&
                    initialDate.DayOfWeek != DayOfWeek.Saturday)
                    daysCount++;
            }

            foreach (Lancamento LancamentoResult in lancamentoList)
            {

                if (datalancamento != LancamentoResult.DateLancamento && datalancamento != "0")
                {
                    countDiasDiasDiferenteLancamento++;
                }
                else
                {
                    countDiasInguasLancamento++;
                }

                datalancamento = LancamentoResult.DateLancamento;
            }
            if (countDiasInguasLancamento > 1)
                countDiasInguasLancamento = 1;

            return daysCount - (countDiasDiasDiferenteLancamento + countDiasInguasLancamento);
        }

        public int CalcularTotalDeAbono(IOrderedEnumerable<Lancamento> lancamentoList)
        {
            int totalAbono = 0;
            foreach (Lancamento LancamentoResult in lancamentoList)
            {
                if (LancamentoResult.CodDivergencia != 0)
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

    

        public List<Fechamento> LancamentoForaDeIntervalo(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
            List<Fechamento> listFachamento = new List<Fechamento>();
            Fechamento novoFechamento = new Fechamento();

            foreach (Lancamento LancamentoResult in lancamentoList)
            {
                if (LancamentoResult.HoraInicio < jornada.HoraInicioDe || LancamentoResult.HoraInicio > jornada.HoraInicioAte || LancamentoResult.HoraFim < jornada.HoraFinal)
                {
                    novoFechamento.Divergencia = "Sim";
                    novoFechamento.DataLancamento = LancamentoResult.DateLancamento.ToDateProtheusReverse();
                    novoFechamento.Descricao = "Dias onde a primeira marcação esteja fora do intervalo informado para os campos “Hora Início de” e “Hora inicio até” na tabela de Intervalos para o período do fechamento.";
                }

                if (LancamentoResult.HoraFim < jornada.HoraFinal)
                {
                    novoFechamento.Divergencia = "Sim";
                    novoFechamento.DataLancamento = LancamentoResult.DateLancamento.ToDateProtheusReverse();
                    novoFechamento.Descricao = "Dias onde a última marcação seja menor que o campo “Hora Saída” na tabela de Intervalos para o período do fechamento.";
                }

            }

            return listFachamento;
        }


        //Inicio das validações de acordo com a MIT
        public Fechamento ValidarApontamentoImpar(Lancamento lancamento, List<Apontamento> apontamento)
        {
            Fechamento novoFechamento = new Fechamento();

            if (VerificaImpar(apontamento))
            {
                novoFechamento.Divergencia = "Sim";
                novoFechamento.DataLancamento = lancamento.DateLancamento;
                novoFechamento.Descricao = "Dias com quantidade de batidas do relógio impar";
            }

            return novoFechamento;
        }

        public bool VerificaImpar(List<Apontamento> apontamento)
        {
            if (!(apontamento.Count % 2 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        public decimal CalcularTotalApontamentoPorDiaLancamento(List<Apontamento> apontamentolist)
        {
            TimeSpan totalhoraApontamemto = TimeSpan.Parse("00:00:00");
            if (!VerificaImpar(apontamentolist))
            {
                for (int i = 0; i < apontamentolist.Count; i = i + 2)
                {
                    totalhoraApontamemto +=  TimeSpan.Parse(Convert.ToString(apontamentolist[i].apontamento)) -TimeSpan.Parse(Convert.ToString(apontamentolist[i+1].apontamento));
                }
            }

            return Math.Abs(Math.Round(Convert.ToDecimal(totalhoraApontamemto.TotalHours), 2));
        }

        public decimal CalcularTotalHoraLancamentoPorDia(List<Lancamento> lancamento)
        {
            TimeSpan totalhoraLancamentoDia = TimeSpan.Parse("00:00:00");
            foreach(Lancamento LancamentoResult in lancamento)
            {
                totalhoraLancamentoDia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
            }
            return Math.Round(Convert.ToDecimal(totalhoraLancamentoDia.TotalHours),2);
        }

        public Fechamento ValidaDiferencaTotalHoraDiaLancamentoTotalApontamento(Lancamento lancamento, decimal totalLancamento,  decimal totalApontamento)
        {
             Fechamento novo = new Fechamento();
             if(totalApontamento < totalLancamento)
               {
                  novo.Divergencia = "Sim";
                  novo.DataLancamento = lancamento.DateLancamento;
                  novo.Descricao = "Dias com diferença entre o total de horas apontado pelas batidas do relógio e pela marcações no sistema";
               }

            return novo;
        }
    }
}
