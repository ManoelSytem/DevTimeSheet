using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Util;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.ViewModel
{
    public class ViewModelFechamento
    {
        public string CodigoMarcacao { get; set; }
        public string DataLancamento { get; set; }
        public string Datafechamento { get; set; }
        public string Descricao { get; set; }
        public string Divergencia { get; set; }
        public double TotalHoraExedente { get; set; }
        public double TotalAtraso { get; set; }
        public double TotalFalta { get; set; }
        public double TotalAbono { get; set; }
        public double TotalHora { get; set; }

        public ViewModelFechamento()
        {
                
        }

        public List<Fechamento> ValidaDiasSemLancamento(List<Lancamento> lancamentolist, Marcacao marcacao, string filial)
        {
            List<Fechamento> novalistFechamento = new List<Fechamento>();
            List<Fechamento> fechamentoSemLancamento = new List<Fechamento>();
            

            Fechamento dataSemLancamento;
            DateTime initialDate = Convert.ToDateTime(marcacao.DataInicio.ToDateProtheusReverseformate());
            DateTime finalDate = Convert.ToDateTime(marcacao.DataFim.ToDateProtheusReverseformate());

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
                    if (!DataLancamentoExiste(initialDate, lancamentolist))
                    {
                        if (!ValidaEferiado(initialDate.ToString("dd/MM/yyyy").ToDateProtheusConvert(), filial))
                        {
                            dataSemLancamento.DataLancamento = initialDate.ToShortDateString();
                            dataSemLancamento.Divergencia = "Divergência";
                            dataSemLancamento.Descricao = "Dia úteis sem marcação";
                            fechamentoSemLancamento.Add(dataSemLancamento);
                        }
                    }
                }

            }
            return fechamentoSemLancamento;
        }

        public List<Fechamento> ValidaDiasComLancamento(List<Lancamento> lancamentolist, Marcacao marcacao, string filial)
        {
            List<Fechamento> novalistFechamento = new List<Fechamento>();
            List<Fechamento> fechamentoSemLancamento = new List<Fechamento>();


            Fechamento dataSemLancamento;
            DateTime initialDate = Convert.ToDateTime(marcacao.DataInicio.ToDateProtheusReverseformate());
            DateTime finalDate = Convert.ToDateTime(marcacao.DataFim.ToDateProtheusReverseformate());

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
                    if (DatanaoExiste(initialDate, lancamentolist))
                    {
                        if (!ValidaEferiado(initialDate.ToString("dd/MM/yyyy").ToDateProtheusConvert(), filial))
                        {
                            dataSemLancamento.DataLancamento = initialDate.ToShortDateString();
                            dataSemLancamento.Divergencia = "Divergência";
                            dataSemLancamento.Descricao = "Dia úteis sem marcação";
                            fechamentoSemLancamento.Add(dataSemLancamento);
                        }
                    }
                }

            }
            return fechamentoSemLancamento;
        }
        public bool ValidaEferiado(string data, string filial)
        {
            ProtheusRepository serviceProthues = new ProtheusRepository();
            var feriado = serviceProthues.ObterFeriadoProthues(data, filial);
            if (feriado.Descricao == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool DatanaoExiste(DateTime data, List<Lancamento> lancamentolist)
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
    }
}
