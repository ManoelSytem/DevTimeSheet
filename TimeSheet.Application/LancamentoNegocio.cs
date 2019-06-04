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
        private readonly IFechamento _fechamentoServiceRepository;
        public LancamentoNegocio(ILancamento lancamentoerviceRepository, IProtheus serviceProthues, IMarcacao marcacao, IFechamento fechamentoServiceRepositor)
        {
            _lancamentoerviceRepository = lancamentoerviceRepository;
            _serviceProthues = serviceProthues;
            _marcacao = marcacao;
            _fechamentoServiceRepository = fechamentoServiceRepositor;
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

            var listFechamento = _fechamentoServiceRepository.ObterListFechamentoMensalPorDia(matricula, codmarcacao);
            var marcacao = _marcacao.ObterMarcacao(codmarcacao);

            if(marcacao.Status == Constantes.FECHADO | marcacao.Status == Constantes.APROVADO | marcacao.Status == Constantes.CONTABILIZADO)
            { 

            foreach (Fechamento FechamentoResult in listFechamento)
            {
                Fechamento novo = new Fechamento();
                novo.DataLancamento = FechamentoResult.DataLancamento;
                novo.CodigoProjeto = FechamentoResult.CodigoProjeto;
                novo.CodigoMarcacao = FechamentoResult.CodigoMarcacao;
                novo.TotalHora = FechamentoResult.TotalHora;
                novo.TotalFaltaAtraso = FechamentoResult.TotalFaltaAtraso;
                novo.TotalHoraExedente = FechamentoResult.TotalHoraExedente;
                novo.TotalAbono = FechamentoResult.TotalAbono;
                listFechamentoCalculada.Add(novo);
            }

            }
            else
            {
                foreach (Lancamento LancamentoAberto in lancamentoList.ToList())
                {
                    Fechamento novo = new Fechamento();
                    novo.DataLancamento = LancamentoAberto.DateLancamento;
                    novo.TotalHora = 0;
                    novo.TotalFaltaAtraso = 0;
                    novo.TotalHoraExedente = 0;
                    novo.TotalAbono = 0;
                        listFechamentoCalculada.Add(novo);
                }

                var listlancamentosSemMarcaco = ObterDiasSemLancamento(lancamentoList.ToList(), _marcacao.ObterMarcacao(codmarcacao), filial, jornada);
                foreach (Fechamento fechamento in listlancamentosSemMarcaco)
                {
                    fechamento.CodigoMarcacao = codmarcacao;
                    fechamento.Filial = filial;
                    fechamento.TotalAbono = 0;
                    fechamento.TotalAtraso = 0;
                    fechamento.TotalFalta = Math.Round(Convert.ToDouble(jornada.JornadaDiaria.Hours), 2);
                    fechamento.TotalFaltaAtraso = 0;
                    fechamento.TotalHoraExedente = 0;
                    fechamento.CodigoProjeto = "0";
                    fechamento.Fase = "0";
                    fechamento.TotalHora = 0;
                    fechamento.Divergencia = "0";
                    listFechamentoCalculada.Add(fechamento);
                }
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

        public List<Fechamento> ValidaIntervaloMinimoEMaximo(List<Lancamento> lancamentoDiario, JornadaTrabalho jornada)
        {
            List<Fechamento> listFechamento = new List<Fechamento>();
            double jornadaDiaria = Math.Round(jornada.JornadaDiaria.TotalHours, 2);
            double minimo = Math.Round(jornada.InterMin.TotalHours, 2);
            double maximo = Math.Round(jornada.InterMax.TotalHours, 2);
            TimeSpan totalHorasIntervalo;
            string datalancamento = "0";
            int count = 0;
            bool existe = false;
            bool eFeriadoSabadoEdomingo = false;

            if (lancamentoDiario.Count > 0)
            {
                for (int i = 0; i < lancamentoDiario.Count; i++)
                {
                    datalancamento = lancamentoDiario[i].DateLancamento.ToDateProtheusReverseformate();
                    if (!ValidaEferiado(lancamentoDiario[i].DateLancamento, jornada.Filial) & !ESabadoOuDomingo(Convert.ToDateTime(lancamentoDiario[i].DateLancamento.ToDateProtheusReverseformate())))
                    {
                        count++;
                        if (lancamentoDiario[i].HoraFim >= jornada.InterInicio && lancamentoDiario[i].HoraFim <= jornada.InterFim)
                        {
                            
                            if (count < lancamentoDiario.Count)
                            {
                                totalHorasIntervalo = lancamentoDiario[i + 1].HoraInicio - lancamentoDiario[i].HoraFim;
                                if (Math.Round(totalHorasIntervalo.TotalHours, 2) >= minimo && Math.Round(totalHorasIntervalo.TotalHours, 2) <= maximo)
                                {
                                    if (lancamentoDiario[i].HoraFim >= jornada.InterInicio && lancamentoDiario[i + 1].HoraInicio <= jornada.InterFim)
                                    {
                                        Fechamento novo = new Fechamento();
                                        listFechamento.Add(novo);
                                        break;
                                    }
                                    if (lancamentoDiario[i+1].CodDivergencia != 0 | lancamentoDiario[i].CodDivergencia != 0)
                                    {
                                        Fechamento novo = new Fechamento();
                                        novo.Divergencia = "Divergência justificada";
                                        novo.DataLancamento = lancamentoDiario[i].DateLancamento.ToDateProtheusReverseformate();
                                        novo.Descricao = "Dia onde intervalo de almoço se encontra diferente do lançamento diário.";
                                        listFechamento.Add(novo);
                                        break;
                                    }
                                    if (lancamentoDiario[i].CodDivergencia == 0 | lancamentoDiario[i+1].CodDivergencia == 0)
                                    {
                                        Fechamento novo = new Fechamento();
                                        novo.Divergencia = "Divergência a justificar";
                                        novo.DataLancamento = lancamentoDiario[i].DateLancamento.ToDateProtheusReverseformate();
                                        novo.Descricao = "Dia onde intervalo de almoço se encontra diferente do lançamento diário.";
                                        listFechamento.Add(novo);
                                        break;
                                    }

                                }
                                else if (!(lancamentoDiario[i].HoraFim >= jornada.InterInicio && lancamentoDiario[i].HoraFim <= jornada.InterFim))
                                {
                                     if (lancamentoDiario[i].CodDivergencia == 0)
                                    {
                                        Fechamento novo = new Fechamento();
                                        novo.Divergencia = "Divergência a justificar";
                                        novo.DataLancamento = lancamentoDiario[i].DateLancamento.ToDateProtheusReverseformate();
                                        novo.Descricao = "Dia onde intervalo de almoço se encontra diferente do lançamento diário.";
                                        listFechamento.Add(novo);
                                        break;
                                    }
                                    else if (lancamentoDiario[i].CodDivergencia != 0)
                                    {
                                        Fechamento novo = new Fechamento();
                                        novo.Divergencia = "Divergência justificada";
                                        novo.DataLancamento = lancamentoDiario[i].DateLancamento.ToDateProtheusReverseformate();
                                        novo.Descricao = "Dia onde intervalo mínimo e máximo se encontra diferente do lançamento diário.";
                                        listFechamento.Add(novo);
                                        break;
                                    }
                                    
                                }
                                else if (!(lancamentoDiario[i+1].HoraFim >= jornada.InterInicio && lancamentoDiario[i+1].HoraFim <= jornada.InterFim))
                                {
                                    if (lancamentoDiario[i+1].CodDivergencia == 0)
                                    {
                                        Fechamento novo = new Fechamento();
                                        novo.Divergencia = "Divergência a justificar";
                                        novo.DataLancamento = lancamentoDiario[i].DateLancamento.ToDateProtheusReverseformate();
                                        novo.Descricao = "Dia onde intervalo de almoço se encontra diferente do lançamento diário.";
                                        listFechamento.Add(novo);
                                        break;
                                    }
                                    else if (lancamentoDiario[i+1].CodDivergencia != 0)
                                    {
                                        Fechamento novo = new Fechamento();
                                        novo.Divergencia = "Divergência justificada";
                                        novo.DataLancamento = lancamentoDiario[i].DateLancamento.ToDateProtheusReverseformate();
                                        novo.Descricao = "Dia onde intervalo de almoço se encontra diferente do lançamento diário.";
                                        listFechamento.Add(novo);
                                        break;
                                    }

                                }


                            }

                        }

                    }
                    else { eFeriadoSabadoEdomingo = true; }
                }

            }


            return listFechamento;
        }
    }
}
