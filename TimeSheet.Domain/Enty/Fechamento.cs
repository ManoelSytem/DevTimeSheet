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
        public string StatusFechamento { get; set; }

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


        
        //Inicio das validações de acordo com a MIT
        public Fechamento ValidarApontamentoImpar(Lancamento lancamento, List<Apontamento> apontamento)
        {
            Fechamento novoFechamento = new Fechamento();

            if (VerificaImpar(apontamento))
            {
                novoFechamento.Divergencia = "Sim";
                novoFechamento.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
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
                    totalhoraApontamemto += TimeSpan.Parse(Convert.ToString(apontamentolist[i].apontamento)) - TimeSpan.Parse(Convert.ToString(apontamentolist[i + 1].apontamento));
                }
            }

            return Math.Abs(Math.Round(Convert.ToDecimal(totalhoraApontamemto.TotalHours), 2));
        }

        public decimal CalcularTotalHoraLancamentoPorDia(List<Lancamento> lancamento)
        {
            TimeSpan totalhoraLancamentoDia = TimeSpan.Parse("00:00:00");
            foreach (Lancamento LancamentoResult in lancamento)
            {
                totalhoraLancamentoDia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
            }
            return Math.Round(Convert.ToDecimal(totalhoraLancamentoDia.TotalHours), 2);
        }

        public Fechamento ValidaDiferencaTotalHoraDiaLancamentoTotalApontamento(Lancamento lancamento, decimal totalLancamento, decimal totalApontamento)
        {
            Fechamento novo = new Fechamento();
            if (totalApontamento < totalLancamento && lancamento.CodDivergencia == 0)
            {
                novo.Divergencia = "Sim";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Dias com diferença entre o total de horas apontado pelas batidas do relógio e pela marcações no sistema";
            }

            return novo;
        }


        public List<Fechamento> ValidaDiferencaEntreBatidas(Lancamento lancamento, List<Apontamento> apontamentolist)
        {
            List<Fechamento> novalistFechamento = new List<Fechamento>();
            if (!VerificaImpar(apontamentolist))
            {
                for (int i = 0; i < apontamentolist.Count; i = i + 2)
                {
                    if ((lancamento.HoraInicio < TimeSpan.Parse(Convert.ToString(apontamentolist[i].apontamento)) | lancamento.HoraInicio > TimeSpan.Parse(Convert.ToString(apontamentolist[i].apontamento))) && lancamento.CodDivergencia == 0)
                    {
                        Fechamento novo = new Fechamento();
                        novo.Divergencia = "Sim";
                        novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                        novo.Descricao = "diferença entre a primeira batida do relógio e o primeiro lançamento no sistema e sem código de divergência";
                        novalistFechamento.Add(novo);
                    }

                    if ((lancamento.HoraFim < TimeSpan.Parse(Convert.ToString(apontamentolist[i + 3].apontamento)) | lancamento.HoraFim < TimeSpan.Parse(Convert.ToString(apontamentolist[i + 3].apontamento))) && lancamento.CodDivergencia == 0)
                    {
                        Fechamento novo = new Fechamento();
                        novo.Divergencia = "Sim";
                        novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                        novo.Descricao = "diferença entre a última batida do relógio e o último lançamento no sistema e sem código de divergência";
                        novalistFechamento.Add(novo);
                    }
                    break;
                }
            }
            return novalistFechamento;
        }

        public Fechamento ValidaDiferencaEntreJornadaDiariaETotalLancamentoDiario(Lancamento lancamento, decimal totalLancamento, JornadaTrabalho jornada)
        {
            Fechamento novo = new Fechamento();
            if (totalLancamento > Math.Round(Convert.ToDecimal(jornada.JornadaDiaria.TotalHours), 2))
            {
                novo.Divergencia = "Sim";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Dias com diferença entre o total apontado e a jornada diária";
            }

            return novo;
        }



        public Fechamento ValidaSabadoDomingoFeriadoComApontamento(Lancamento lancamento, Feriado feriado)
        {
            Fechamento novo = new Fechamento();

            if ((Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Sunday |
               Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Saturday | feriado.Descricao != null) && lancamento.CodDivergencia == 0)
            {
                novo.Divergencia = "Sim";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Sábados, domingos e feriados com apontamento e sem código de divergência";

            }
            return novo;
        }

        public List<Fechamento> ValidaDiasSemLancamento(List<Lancamento> lancamentolist, JornadaTrabalho jornada)
        {
            List<Fechamento> novalistFechamento = new List<Fechamento>();
            List<Fechamento> fechamentoSemLancamento = new List<Fechamento>();
            Fechamento dataSemLancamento;
            DateTime initialDate = jornada.DataInicio;
            DateTime finalDate = jornada.DataFim;

            var days = 0;
            days = initialDate.Subtract(finalDate).Days;

            if (days < 0)
                days = days * -1;

            for (int i = 1; i <= days; i++)
            {
                initialDate = initialDate.AddDays(1);
                dataSemLancamento = new Fechamento();
                if (initialDate.DayOfWeek != DayOfWeek.Sunday
                     &&
                    initialDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    if (!DataLancamentoExiste(initialDate,lancamentolist))
                    {
                        dataSemLancamento.DataLancamento = initialDate.ToShortDateString();
                        dataSemLancamento.Divergencia = "Sim";
                        dataSemLancamento.Descricao = "Dias úteis sem marcação";
                        fechamentoSemLancamento.Add(dataSemLancamento);
                    }
                }
                   
            }

            return fechamentoSemLancamento;
        }

        public bool DataLancamentoExiste(DateTime data, List<Lancamento> lancamentolist)
        {
            bool valor = false;
            foreach (Lancamento LancamentoResult in lancamentolist)
            {
                if (Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate()) == data)
                {
                    valor = true;
                }
            }
            return valor;
        }

        public List<Fechamento> LancamentoForaDeIntervalo(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
            List<Fechamento> listFachamento = new List<Fechamento>();
            Fechamento novoFechamento = new Fechamento();

            foreach (Lancamento LancamentoResult in lancamentoList)
            {
                if ((LancamentoResult.HoraInicio < jornada.HoraInicioDe | LancamentoResult.HoraInicio > jornada.HoraInicioAte | LancamentoResult.HoraFim < jornada.HoraFinal) && LancamentoResult.CodDivergencia == 0)
                {
                    novoFechamento.Divergencia = "Sim";
                    novoFechamento.DataLancamento = LancamentoResult.DateLancamento.ToDateProtheusReverseformate();
                    novoFechamento.Descricao = "Dias onde a primeira marcação esteja fora do intervalo informado para os campos “Hora Início de” e “Hora inicio até” na tabela de Intervalos para o período do fechamento.";
                    listFachamento.Add(novoFechamento);
                }

                if ((LancamentoResult.HoraFim < jornada.HoraFinal) && LancamentoResult.CodDivergencia == 0)
                {
                    novoFechamento.Divergencia = "Sim";
                    novoFechamento.DataLancamento = LancamentoResult.DateLancamento.ToDateProtheusReverseformate();
                    novoFechamento.Descricao = "Dias onde a última marcação seja menor que o campo “Hora Saída” na tabela de Intervalos para o período do fechamento.";
                    listFachamento.Add(novoFechamento);
                }

                if ((LancamentoResult.HoraInicio > jornada.InterInicio && LancamentoResult.HoraInicio < jornada.HoraInicioAte) && LancamentoResult.CodDivergencia == 0)
                {
                    novoFechamento.Divergencia = "Sim";
                    novoFechamento.DataLancamento = LancamentoResult.DateLancamento.ToDateProtheusReverseformate();
                    novoFechamento.Descricao = "Dias onde o intervalo esteja fora do intervalo informado para os campos “Intervalo de” e “Intervalo até” na tabela de Intervalos para o período do fechamento.";
                    listFachamento.Add(novoFechamento);
                }

            }

            return listFachamento;
        }

    }

}
