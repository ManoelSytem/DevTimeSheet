using System;
using System.Collections.Generic;
using System.Linq;
using TimeSheet.Application.Interface;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;


namespace TimeSheet.Application
{
    public class LancamentoNegocio : ILancamentoNegocio
    {
        private readonly ILancamento _lancamentoerviceRepository;
        private readonly IProtheus _serviceProthues;
        private readonly IMarcacao _marcacao;
        public LancamentoNegocio(ILancamento lancamentoerviceRepository, IProtheus serviceProthues, IMarcacao marcacao)
        {
            _lancamentoerviceRepository = lancamentoerviceRepository;
            _serviceProthues = serviceProthues;
            _marcacao = marcacao;
        }

        public List<Fechamento> CalcularLancamentoPorData(IEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho, Configuracao configura, string matricula, string filial, string codmarcacao)
        {
            List<Fechamento> listaFechamentoPorData = new List<Fechamento>();


            listaFechamentoPorData = CalcularTotalHoraExedenteETrabalhadaEabonoeFalta(orderedlistalancamento.OrderBy(x => x.DateLancamento), jornadaTrabalho, configura, matricula, filial, codmarcacao);
            return listaFechamentoPorData;
        }

        public List<Fechamento> CalcularTotalHoraExedenteETrabalhadaEabonoeFalta(IEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada, Configuracao config, string matricula, string filial, string codmarcacao)
        {

            List<Fechamento> listFechamentoCalculada = new List<Fechamento>();
            double totalLancamento = 0;
            double totalHoraExedente = 0;
            double totalAbono = 0;
            var jrDiaria = jornada.JornadaDiaria;

            foreach (Lancamento LancamentoResult in lancamentoList)
            {

                var listlancamentoDiario = _lancamentoerviceRepository.ObterLancamento(LancamentoResult.DateLancamento, matricula);

                totalAbono += CalcularTotaAbono(LancamentoResult, config);
                totalLancamento = CalcularTotalLancamentoPorDia(listlancamentoDiario);
                Fechamento novo = new Fechamento();
                if (totalLancamento > Math.Round(Convert.ToDouble(jrDiaria.TotalHours), 2))
                {
                    novo.TotalHora = totalLancamento;
                    novo.DataLancamento = LancamentoResult.DateLancamento;
                    novo.CodigoProjeto = LancamentoResult.codEmpredimento;
                    novo.CodigoMarcacao = LancamentoResult.Codigo;
                    novo.Fase = LancamentoResult.Fase;
                    totalHoraExedente = totalLancamento - Math.Round(Convert.ToDouble(jrDiaria.TotalHours), 2);
                    novo.TotalFalta = 0;
                    if (Eabono(LancamentoResult, config)) novo.TotalAbono = totalAbono;
                    if (ValidaEferiado(LancamentoResult.DateLancamento, filial) | ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate())))
                    {
                        novo.TotalHoraExedente = Math.Round(Convert.ToDouble(totalHoraExedente), 2);
                    }
                    else { novo.TotalHoraExedente = Math.Round(Convert.ToDouble(totalHoraExedente), 2); }
                    listFechamentoCalculada.Add(novo);
                    totalLancamento = 0;
                    totalAbono = 0;
                    totalHoraExedente = 0;
                }
                else
                {
                    if (ValidaEferiado(LancamentoResult.DateLancamento, filial) | ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate())))
                    {
                        novo.TotalHoraExedente = totalLancamento;
                        novo.TotalAtraso = 0;
                    }
                    else { novo.TotalHoraExedente = 0;
                        novo.TotalAtraso = Math.Round(Convert.ToDouble((jrDiaria).TotalHours), 2) - totalLancamento;
                    }
                    novo.DataLancamento = LancamentoResult.DateLancamento;
                    novo.CodigoProjeto = LancamentoResult.codEmpredimento;
                    novo.CodigoMarcacao = LancamentoResult.Codigo;
                    novo.Fase = LancamentoResult.Fase;
                    novo.TotalFalta = 0;
                    if (Eabono(LancamentoResult, config)) novo.TotalAbono = totalAbono;
                    novo.TotalHora = totalLancamento;
                    listFechamentoCalculada.Add(novo);
                    totalAbono = 0;
                    totalHoraExedente = 0;
                    totalLancamento = 0;
                }

            }

           
              var listlancamentosSemMarcaco = ObterDiasSemLancamento(lancamentoList.ToList(), _marcacao.ObterMarcacao(codmarcacao), filial, jornada);
             foreach (Fechamento fechamento in listlancamentosSemMarcaco)
             {
                listFechamentoCalculada.Add(fechamento);
             }

            return listFechamentoCalculada;
        }


        public double CalcularTotalLancamentoPorDia(List<Lancamento> listlancamentoDiario)
        {
            double totalHorasLancamento = 0;
            TimeSpan totalLancamento = TimeSpan.Parse("00:00:00");
            foreach (Lancamento LancamentoResult in listlancamentoDiario)
            {
                totalLancamento += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
            }

            return totalHorasLancamento = Math.Round(Convert.ToDouble(totalLancamento.TotalHours), 2);
        }

        public bool ESabadoOuDomingo(DateTime initialDate)
        {
            if (initialDate.DayOfWeek == DayOfWeek.Sunday
                    &&
                   initialDate.DayOfWeek == DayOfWeek.Saturday)
                return true;
            else return false;
        }
        public double CalcularTotaAbono(Lancamento lancamento, Configuracao config)
        {
            int totalAbono = 0;

            if (lancamento.HoraInicio != TimeSpan.Parse("00:00:00") && lancamento.CodDivergencia != 0)
            {
                totalAbono++;
            }
            return totalAbono;
        }

        public bool Eabono(Lancamento lancamento, Configuracao config)
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


        public List<Fechamento> ObterDiasSemLancamento(List<Lancamento> lancamentolist, Marcacao marcacao, string filial, JornadaTrabalho jornada)
        {
            List<Fechamento> novalistFechamento = new List<Fechamento>();
            List<Fechamento> fechamentoSemLancamento = new List<Fechamento>();
            var jrDiaria = jornada.JornadaDiaria;

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
                            
                            dataSemLancamento.DataLancamento = initialDate.ToString("dd/MM/yyyy").ToDateProtheusConvert();
                            dataSemLancamento.TotalAbono = 0;
                            dataSemLancamento.TotalHoraExedente = 0;
                            dataSemLancamento.TotalFalta = Math.Round(Convert.ToDouble((jrDiaria).TotalHours), 2);
                            dataSemLancamento.TotalAtraso = 0;
                            dataSemLancamento.TotalHora = 0;
                            fechamentoSemLancamento.Add(dataSemLancamento);
                        }
                    }
                }

            }
            return fechamentoSemLancamento;
        }

        public bool ValidaEferiado(string data, string filial)
        {

            var feriado = _serviceProthues.ObterFeriadoPorDataLancamento(data, filial);
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
