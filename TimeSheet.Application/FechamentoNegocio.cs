using System;
using System.Collections.Generic;
using System.Linq;
using TimeSheet.Application.Interface;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Application
{
    public class FechamentoNegocio : IFechamentoNegocio
    {

        private readonly ILancamento _lancamentoerviceRepository;
        private readonly IProtheus _serviceProthues;
        private readonly IMarcacao _marcacao;
        private readonly IFechamento _fechamentoServiceRepository;
        public FechamentoNegocio(ILancamento lancamentoerviceRepository, IProtheus serviceProthues, IMarcacao marcacao, IFechamento fechamentoServiceRepository)
        {
            _fechamentoServiceRepository = fechamentoServiceRepository;
            _lancamentoerviceRepository = lancamentoerviceRepository;
            _serviceProthues = serviceProthues;
            _marcacao = marcacao;
        }
        //Inicio Calculo Fechamento.
        public List<Fechamento> CalcularLancamentoPorProjeto(IEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho, Configuracao configura, string matricula, string filial, string codmarcacao)
        {
            List<Fechamento> listaFechamentoPorData = new List<Fechamento>();

            listaFechamentoPorData = CalcularTotalLancamentoPorProjeto(orderedlistalancamento.OrderBy(x => x.DateLancamento).ToList(), matricula, jornadaTrabalho, configura, filial, codmarcacao);
            return listaFechamentoPorData;
        }


        public Fechamento CalcularTotalGeralMensalPorDia(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada, Configuracao config, string matricula, string filial, string codmarcacao)
        {
            TimeSpan totalLancamento = TimeSpan.Parse("00:00:00");
            double totalgeral = 0;
            double totalHoraExedente = 0;
            double totalAbono = 0;
            TimeSpan totalHorasNaoTrabalhada = TimeSpan.Parse("00:00:00");
            var jrDiaria = jornada.JornadaMax;
            List<Fechamento> Fechamento = new List<Fechamento>();
            string codEmprendimento = "0";
            string data = "";
            double totalHorasLancamento = 0;

            Fechamento fechamento = new Fechamento();
            foreach (Lancamento LancamentoResult in lancamentoList)
            {

                var listaLancamentoPorDia = _lancamentoerviceRepository.ObterLancamento(LancamentoResult.DateLancamento, matricula);
                if (listaLancamentoPorDia.Count > 0)
                {
                    totalAbono += Math.Round(CalcularTotalHorasAbono(listaLancamentoPorDia).TotalHours,2);
                    totalLancamento = CalcularTotalHoraLancamentoPorDia(listaLancamentoPorDia);
                    if (ValidaEferiado(LancamentoResult.DateLancamento, filial) | ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate())))
                    {
                        totalHoraExedente += Math.Round(totalLancamento.TotalHours,2);
                    }
                    else if (totalLancamento > jrDiaria)
                    {
                        var exedente = totalLancamento - jornada.JornadaDiaria;
                        totalHoraExedente += Math.Round(exedente.TotalHours,2);
                    }

                    if (!ValidaEferiado(LancamentoResult.DateLancamento, filial) | !ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate())))
                    {
                        totalHorasNaoTrabalhada += CalcularTotalNaoTrabalhadas(listaLancamentoPorDia);
                        
                    }
                    totalgeral += Math.Round(totalLancamento.TotalHours, 2);
                }

            }

            fechamento.TotalAbono = totalAbono;
            fechamento.TotalFaltaAtraso = Math.Round(totalHorasNaoTrabalhada.TotalHours,2);
            fechamento.TotalHoraExedente = totalHoraExedente;
            fechamento.TotalHora = totalgeral;
            return fechamento;
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


        public List<Fechamento> ValidaDiasSemLancamento(List<Lancamento> lancamentolist, Marcacao marcacao, string filial)
        {
            List<Fechamento> novalistFechamento = new List<Fechamento>();
            List<Fechamento> fechamentoSemLancamento = new List<Fechamento>();


            Fechamento dataSemLancamento;
            DateTime initialDate = Convert.ToDateTime(marcacao.DataInicio.ToDateProtheusReverseformate());
            DateTime finalDate = Convert.ToDateTime(marcacao.DataFim.ToDateProtheusReverseformate());

            var days = 0;
            days = initialDate.Subtract(finalDate).Days;
            int primeiroDia = 0;

            int count = 0;
            if (days < 0)
                days = days * -1;
            for (int i = 0; i <= days; i++)
            {
                int proximoDia = 1;
                if (primeiroDia == 0)
                {
                    proximoDia = primeiroDia;
                }
                initialDate = initialDate.AddDays(proximoDia);
                primeiroDia++;
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
                            dataSemLancamento.Divergencia = "Divergência a justificar";
                            dataSemLancamento.Descricao = "Dia útil sem marcação.";
                            fechamentoSemLancamento.Add(dataSemLancamento);
                        }
                    }
                }

            }
            return fechamentoSemLancamento;
        }
        //Fim Calculo.
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
                            dataSemLancamento.Divergencia = "Divergência a justificar";
                            dataSemLancamento.Descricao = "Dia útil sem marcação.";
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

        //Inicio das validações de acordo com a MIT
        public Fechamento ValidarApontamentoImpar(Fechamento fechamento, List<Apontamento> apontamento)
        {
            Fechamento novoFechamento = new Fechamento();

            if (VerificaImpar(apontamento))
            {
                novoFechamento.Divergencia = "Divergência justificada";
                novoFechamento.DataLancamento = fechamento.DataLancamento;
                novoFechamento.Descricao = "Dia com quantidade de batidas do relógio impar.";
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

        public decimal CalcularTotalApontamentoPorDiaLancamento(List<Apontamento> apontamentolist, List<Lancamento> listlancamento)
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

        public TimeSpan CalcularTotalHoraLancamentoPorDia(List<Lancamento> lancamento)
        {
            TimeSpan totalhoraLancamentoDia = TimeSpan.Parse("00:00:00");
           
            foreach (Lancamento LancamentoResult in lancamento)
            {
               CodDivergencia CodDivergencia = new CodDivergencia();
                if (LancamentoResult.CodDivergencia != 0) { 
                   CodDivergencia = _serviceProthues.ObterTipoCodigoDivergencia(Convert.ToString(LancamentoResult.CodDivergencia));
                }
                 if (CodDivergencia.Constant != Constantes.NAOTRABALHADA)
                  {
                        totalhoraLancamentoDia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
                  }   
                

            }
            return totalhoraLancamentoDia;
        }


        public double CalcularTotalHoraExedentes(List<Lancamento> lancamento)
        {
            TimeSpan totalhoraLancamentoDia = TimeSpan.Parse("00:00:00");
            foreach (Lancamento LancamentoResult in lancamento)
            {
                var CodDivergencia = _serviceProthues.ObterTipoCodigoDivergencia(Convert.ToString(LancamentoResult.CodDivergencia));
                if (CodDivergencia != null)
                {
                    if (CodDivergencia.Constant == Constantes.HRSEXCEDENTES)
                    {
                        totalhoraLancamentoDia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
                    }
                }

            }
            return Math.Round(Convert.ToDouble(totalhoraLancamentoDia.TotalHours), 2);
        }

        public double CalcularTotalHoraExedentesSemCodigo(List<Lancamento> lancamento, JornadaTrabalho jornada)
        {
            TimeSpan totalhoraLancamentoDia = TimeSpan.Parse("00:00:00");
            double totalGeral = 0;
            foreach (Lancamento LancamentoResult in lancamento)
            {

                totalhoraLancamentoDia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;

            }

            if (Math.Round(Convert.ToDouble(totalhoraLancamentoDia.TotalHours), 2) > Math.Round(Convert.ToDouble(jornada.JornadaMax.TotalHours), 2))
            {
                totalGeral = Math.Round(Convert.ToDouble(totalhoraLancamentoDia.TotalHours), 2) - Math.Round(Convert.ToDouble(jornada.JornadaMax.TotalHours), 2);
                return Math.Round(totalGeral, 2);
            }
            else
            {
                return 0;
            }
        }


        public Fechamento ValidarDiferencaHorasExcedentes(double TotalhorasExcedentesComCodigo, double TotalhorasExcedentesSemCodigo, string datalancamento, JornadaTrabalho jornada)
        {
            Fechamento novo = new Fechamento();
            if (TotalhorasExcedentesSemCodigo != 0)
            {
                if (!(TotalhorasExcedentesComCodigo >= TotalhorasExcedentesSemCodigo))
                {
                    novo.Divergencia = "Divergência a justificar";
                    novo.DataLancamento = datalancamento.ToDateProtheusReverseformate();
                    novo.Descricao = "Dia onde o total de horas excedentes é diferente do total de horas com código de divergência.";
                }

            }
            return novo;
        }
        public List<Fechamento> ValidaSeExisteMarcacaoAntesEdepoisDoApontamento(List<Lancamento> listlancamento, List<Apontamento> apontamentolist)
        {
            string mensagem = "Dia com diferença entre o total de horas apontado pelas batidas do relógio e pela marcações no sistema.";
            List<Fechamento> listFechamento = new List<Fechamento>();

            if (listlancamento.Count > 0)
            {
                Fechamento novo = new Fechamento();
                if (!VerificaImpar(apontamentolist))
                {

                    if (apontamentolist.Count > 0)
                    {

                        if ((listlancamento.FirstOrDefault().HoraInicio < apontamentolist.FirstOrDefault().apontamento | listlancamento.FirstOrDefault().HoraFim > apontamentolist.LastOrDefault().apontamento) && listlancamento.FirstOrDefault().CodDivergencia == 0)
                        {

                            novo.Divergencia = "Divergência a justificar";
                            novo.DataLancamento = listlancamento.FirstOrDefault().DateLancamento.ToDateProtheusReverseformate();
                            novo.Descricao = mensagem;

                        }
                        else if ((listlancamento.FirstOrDefault().HoraInicio < apontamentolist.FirstOrDefault().apontamento | listlancamento.FirstOrDefault().HoraFim > apontamentolist.LastOrDefault().apontamento) && listlancamento.FirstOrDefault().CodDivergencia != 0)
                        {
                            novo.Divergencia = "Divergência justificada";
                            novo.DataLancamento = listlancamento.FirstOrDefault().DateLancamento.ToDateProtheusReverseformate();
                            novo.Descricao = mensagem;

                        }

                        if ((listlancamento.LastOrDefault().HoraFim < apontamentolist.LastOrDefault().apontamento) && listlancamento.LastOrDefault().CodDivergencia == 0)
                        {
                            novo.Divergencia = "Divergência a justificar";
                            novo.DataLancamento = listlancamento.LastOrDefault().DateLancamento.ToDateProtheusReverseformate();
                            novo.Descricao = mensagem;


                        }
                        else if ((listlancamento.LastOrDefault().HoraFim < apontamentolist.LastOrDefault().apontamento) && listlancamento.LastOrDefault().CodDivergencia != 0)
                        {

                            novo.Divergencia = "Divergência justificada";
                            novo.DataLancamento = listlancamento.LastOrDefault().DateLancamento.ToDateProtheusReverseformate();
                            novo.Descricao = mensagem;

                        }

                    }
                    listFechamento.Add(novo);
                }

            }
            return listFechamento;
        }

        public Fechamento ValidaPrimeiroLancamento(Lancamento lancamento, List<Apontamento> apontamentolist)
        {
            Fechamento FechamentoRetorno = new Fechamento();

                for (int i = 0; i < apontamentolist.Count; i = i + 2)
                {
                    if ((lancamento.HoraInicio < TimeSpan.Parse(Convert.ToString(apontamentolist[i].apontamento)) | lancamento.HoraInicio > TimeSpan.Parse(Convert.ToString(apontamentolist[i].apontamento))) && lancamento.CodDivergencia == 0)
                    {
                        Fechamento novo = new Fechamento();
                        novo.Divergencia = "Divergência a justificar";
                        novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                        novo.Descricao = "Dia com diferença entre a primeira batida do relógio e o primeiro lançamento no sistema e sem código de divergência";
                        return novo;

                    }
                    else if ((lancamento.HoraInicio < TimeSpan.Parse(Convert.ToString(apontamentolist[i].apontamento)) | lancamento.HoraInicio > TimeSpan.Parse(Convert.ToString(apontamentolist[i].apontamento))) && lancamento.CodDivergencia != 0)
                    {
                        Fechamento novo = new Fechamento();
                        novo.Divergencia = "Divergência  justificada";
                        novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                        novo.Descricao = "Dia com diferença entre a primeira batida do relógio e o primeiro lançamento no sistema";
                        return novo;
                    }
                    break;
                }
            return FechamentoRetorno;
        }


        public Fechamento ValidaUltimoLancamento(Lancamento lancamento, List<Apontamento> apontamentolist)
        {
            var mensagem = "Dia com diferença entre a última batida do relógio e o último lançamento no sistema.";
            if (apontamentolist.Count > 0)
            {
                if ((lancamento.HoraFim > apontamentolist.LastOrDefault().apontamento | lancamento.HoraFim < apontamentolist.LastOrDefault().apontamento) && lancamento.CodDivergencia == 0)
                {
                    mensagem = "Dia com diferença entre a última batida do relógio e o último lançamento no sistema.";

                    return new Fechamento()
                    {
                        Divergencia = "Divergência a justificar",
                        DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate(),
                        Descricao = mensagem
                    };

                }
                else if ((lancamento.HoraFim > apontamentolist.LastOrDefault().apontamento | lancamento.HoraFim < apontamentolist.LastOrDefault().apontamento) && lancamento.CodDivergencia != 0)
                {
                    return new Fechamento()
                    {
                        Divergencia = "Divergência justificada",
                        DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate(),
                        Descricao = mensagem
                    };
                }
                else
                {
                    return new Fechamento()
                    {
                        Descricao = null
                    };
                }
            }
            else
            {
                return new Fechamento()
                {
                    Descricao = null
                };
            }

        }

        public Fechamento ValidaDiferencaEntreJornadaDiariaETotalLancamentoDiario(List<Lancamento> lancamento, decimal totalLancamento, JornadaTrabalho jornada)
        {
            TimeSpan totalhoraLancamentoDia = TimeSpan.Parse("00:00:00");
            bool ESabadoDomingoOuFeriado = false;
            foreach (Lancamento LancamentoResult in lancamento)
            {
              totalhoraLancamentoDia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
            }

            TimeSpan diferenca = jornada.JornadaDiaria - totalhoraLancamentoDia;
            string mensagem = $"Dia com hora excedente. Jornada máxima: {jornada.JornadaMax.ToString(@"hh\:mm")}, total apontado : {totalhoraLancamentoDia.ToString(@"hh\:mm")}.";
            string datalancamento = "0";
            TimeSpan totalhoraLancamentoDiaComCodigoDivergencia = TimeSpan.Parse("00:00:00");
            Fechamento novo = new Fechamento();
            bool existeCodigoDivergencia = false;
            foreach (Lancamento LancamentoResult in lancamento)
            {
                ESabadoDomingoOuFeriado = ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate()));
                datalancamento = LancamentoResult.DateLancamento.ToDateProtheusReverseformate();
                var CodDivergencia = _serviceProthues.ObterTipoCodigoDivergencia(Convert.ToString(LancamentoResult.CodDivergencia));
                if (CodDivergencia != null)
                {
                    if(CodDivergencia.Constant == Constantes.HRSEXCEDENTES)
                    {
                        totalhoraLancamentoDiaComCodigoDivergencia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
                        existeCodigoDivergencia = true;
                    }

                }
            }

            foreach (Lancamento LancamentoResult in lancamento)
            {
                datalancamento = LancamentoResult.DateLancamento.ToDateProtheusReverseformate();
                var CodDivergencia = _serviceProthues.ObterTipoCodigoDivergencia(Convert.ToString(LancamentoResult.CodDivergencia));
                if (CodDivergencia != null)
                { 
                    existeCodigoDivergencia = true;
                    break;
                }
            }

            double total = Convert.ToDouble(totalLancamento);

            if (total < Math.Round(Convert.ToDouble(jornada.JornadaMin.TotalHours), 2) && existeCodigoDivergencia == false && ESabadoDomingoOuFeriado == false)
            {
                novo.Divergencia = "Divergência a justificar";
                novo.DataLancamento = datalancamento;
                novo.Descricao = $"Dia com diferença entre o total apontado e a jor" +
                    $"nada mínima. Jornada mínima: {jornada.JornadaMin.ToString(@"hh\:mm")}, total apontado : {totalhoraLancamentoDia.ToString(@"hh\:mm")}.";
            }
            if (total < Math.Round(Convert.ToDouble(jornada.JornadaDiaria.TotalHours), 2) && existeCodigoDivergencia == true && ESabadoDomingoOuFeriado == false)
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = datalancamento;
                novo.Descricao = $"Dia com diferença entre o total apontado e a jor" +
                    $"nada mínima. Jornada mínima: {jornada.JornadaMin.ToString(@"hh\:mm")}, total apontado : {totalhoraLancamentoDia.ToString(@"hh\:mm")}.";
            }
            if (total < Math.Round(Convert.ToDouble(jornada.JornadaDiaria.TotalHours), 2)  && ESabadoDomingoOuFeriado == true)
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = datalancamento;
                novo.Descricao = $"Sabado, domingo ou feriado com lançamento é considerado como hora excedente.";

            }
            if (total > Math.Round(Convert.ToDouble(jornada.JornadaDiaria.TotalHours), 2)  && ESabadoDomingoOuFeriado == true)
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = datalancamento;
                novo.Descricao = $"Sabado, domingo ou feriado com lançamento é considerado como hora excedente.";
            }
            else if (total > Math.Round(Convert.ToDouble(jornada.JornadaDiaria.TotalHours), 2) && ESabadoDomingoOuFeriado == true)
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = datalancamento;
                novo.Descricao = $"Sabado, domingo ou feriado com lançamento é considerado como hora excedente.";
            }
            if (total > Math.Round(Convert.ToDouble(jornada.JornadaMax.TotalHours), 2) && ESabadoDomingoOuFeriado == false)
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = datalancamento;
                novo.Descricao = mensagem+ " Excedente: " + diferenca.ToString(@"hh\:mm") + ".";
            }
            return novo;
        }

        public Fechamento ValidaSabadoDomingoFeriadoComApontamento(Lancamento lancamento, Feriado feriado)
        {
            Fechamento novo = new Fechamento();

            if ((Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Sunday |
               Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Saturday | feriado.Descricao != null) && lancamento.CodDivergencia == 0)
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Sábados, domingos e feriados com lançamento.";

            }
            if ((Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Sunday |
               Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Saturday | feriado.Descricao != null) && lancamento.CodDivergencia != 0)
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Sábados, domingos e feriados com lançamentos.";

            }
            return novo;
        }


        public Fechamento ValidarLancamentoForaDeJornadaInicio(Lancamento lancamento, JornadaTrabalho jornada)
        {
            Fechamento novoFechamento = new Fechamento();

            if ((lancamento.HoraInicio > jornada.HoraInicioDe | lancamento.HoraInicio < jornada.HoraInicioAte) && lancamento.CodDivergencia == 0)
            {
                Fechamento novo = new Fechamento();
                novoFechamento.Divergencia = "Divergência a justificar";
                novoFechamento.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novoFechamento.Descricao = "Dia onde a primeira marcação esteja fora do intervalo informado para os campos “Hora Início de” e “Hora inicio até” na tabela de Intervalos para o período do fechamento.";
                return novo;
            }
            if ((lancamento.HoraInicio > jornada.HoraInicioDe | lancamento.HoraInicio < jornada.HoraInicioAte) && lancamento.CodDivergencia != 0)
            {
                Fechamento novo = new Fechamento();
                novoFechamento.Divergencia = "Divergência justificada";
                novoFechamento.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novoFechamento.Descricao = "Dia onde a primeira marcação esteja fora do intervalo informado para os campos “Hora Início de” e “Hora inicio até” na tabela de Intervalos para o período do fechamento.";
                return novo;
            }
            return novoFechamento;
        }


        public Fechamento ValidarUltimoLancamentoForaDeJornada(Lancamento lancamento, JornadaTrabalho jornada)
        {
            Fechamento novoFechamento = new Fechamento();
            if (!ESabadoOuDomingo(Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate())) && !(ValidaEferiado(lancamento.DateLancamento.ToDateProtheusReverseformate(),jornada.Filial)) ) { 
            if ((lancamento.HoraFim < jornada.HoraFinal) && lancamento.CodDivergencia == 0)
            {
                Fechamento novo = new Fechamento();
                novoFechamento.Divergencia = "Divergência a justificar";
                novoFechamento.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novoFechamento.Descricao = "Dia onde a última marcação seja menor que o campo “Hora Saída” na tabela de Intervalos para o período do fechamento.";
            }
            if ((lancamento.HoraFim < jornada.HoraFinal) && lancamento.CodDivergencia != 0)
            {
                Fechamento novo = new Fechamento();
                novoFechamento.Divergencia = "Divergência justificada";
                novoFechamento.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novoFechamento.Descricao = "Dia onde a última marcação seja menor que o campo “Hora Saída” na tabela de Intervalos para o período do fechamento.";
            }
            }
            return novoFechamento;
        }

        public Fechamento ValidarLancamentoForaDeIntervaloInicio(Lancamento lancamento, JornadaTrabalho jornada)
        {
            Fechamento novoFechamento = new Fechamento();

            if ((lancamento.HoraInicio >= jornada.InterInicio && lancamento.HoraInicio <= jornada.InterFim) && lancamento.CodDivergencia == 0)
            {
                Fechamento novo = new Fechamento();
                novoFechamento.Divergencia = "Divergência a justificar";
                novoFechamento.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novoFechamento.Descricao = "Dia onde a primeira marcação esteja fora do intervalo informado para os campos “Hora Início de” e “Hora inicio até” na tabela de Intervalos para o período do fechamento.";
            }
            return novoFechamento;
        }
        //Fim Validação Mit.
        public List<Fechamento> CalcularTotalHoraExedenteETrabalhadaEabonoeFaltaPorDia(List<Lancamento> listlancamentoDiario, Configuracao config, JornadaTrabalho jornada, string matricula, string filial, string codmarcacao)
        {
            List<Fechamento> listFechamentoCalculadaPorDia = new List<Fechamento>();
            TimeSpan totalAbono = TimeSpan.Parse("00:00:00");
            TimeSpan totalLancamento = TimeSpan.Parse("00:00:00");
            double totalHoraExedente = 0;
            double totalFaltaAtraso = 0;


            foreach (Lancamento LancamentoResult in listlancamentoDiario)
            {
                var listaLancamentoPorDia = _lancamentoerviceRepository.ObterLancamento(LancamentoResult.DateLancamento, matricula);
                if (listaLancamentoPorDia.Count > 0)
                {
                    totalAbono += CalcularTotalHorasAbono(listaLancamentoPorDia);
                    totalLancamento = CalcularTotalHoraLancamentoPorDia(listaLancamentoPorDia);
                    Fechamento novo = new Fechamento();
                    novo.DataLancamento = LancamentoResult.DateLancamento;
                    novo.CodigoProjeto = "00000";
                    novo.CodigoMarcacao = codmarcacao;
                    novo.TotalHora = Math.Round(totalLancamento.TotalHours, 2);
                    novo.Fase = "0";
                    if (ValidaEferiado(LancamentoResult.DateLancamento, filial) | ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate())))
                    {
                        novo.TotalHoraExedente = Math.Round(totalLancamento.TotalHours,2);
                    }
                    else if (totalLancamento > jornada.JornadaMax)
                    {
                        var exedente = totalLancamento - jornada.JornadaDiaria;
                        novo.TotalHoraExedente = Math.Round(exedente.TotalHours, 2);
                    }
                    if (!ValidaEferiado(LancamentoResult.DateLancamento, filial) | !ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate())))
                    {
                        novo.TotalAbono = Math.Round(totalAbono.TotalHours,2);
                        novo.TotalFaltaAtraso = Math.Round(CalcularTotalNaoTrabalhadas(listaLancamentoPorDia).TotalHours,2);
                        
                    }
                    if (ValidaEferiado(LancamentoResult.DateLancamento, filial) | ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate())))
                    {
                    }
                    else
                    {
                        novo.TotalAbono = Math.Round(totalAbono.TotalHours, 2);
                    }
                    listFechamentoCalculadaPorDia.Add(novo);
                }
                totalAbono = TimeSpan.Parse("00:00:00");
                totalLancamento = TimeSpan.Parse("00:00:00");
                totalHoraExedente = 0;
                totalFaltaAtraso = 0;
            }
            return listFechamentoCalculadaPorDia;
        }

        public List<Fechamento> CalcularTotalLancamentoPorProjeto(List<Lancamento> listlancamentoDiario, string matricula, JornadaTrabalho jornada, Configuracao config, string filial, string codmarcacao)
        {
            double totalLancamento = 0;
            double totalHoraExedente = 0;
            double totalAbono = 0;
            string datalancamento = "0";
            var jrDiaria = jornada.JornadaDiaria;
            List<Fechamento> Fechamento = new List<Fechamento>();
            string codEmprendimento = "0";
            string data = "";
            double totalHorasLancamento = 0;

            foreach (Lancamento LancamentoResult in listlancamentoDiario)
            {

                var listaPorEmprendimentoDia = _lancamentoerviceRepository.ObterListaLancamentoPorCodProjeto(LancamentoResult.DateLancamento, matricula, LancamentoResult.codEmpredimento);
                if (listaPorEmprendimentoDia.Count > 0)
                {

                    totalLancamento += CalcularTotalHorasLancamentoPorProjeto(listaPorEmprendimentoDia);

                    Fechamento novo = new Fechamento();
                    novo.DataLancamento = LancamentoResult.DateLancamento;
                    novo.CodigoProjeto = LancamentoResult.codEmpredimento;
                    novo.CodigoMarcacao = codmarcacao;
                    novo.Fase = LancamentoResult.Fase;
                    novo.TotalAbono = 0;
                    novo.TotalHoraExedente = 0;
                    novo.TotalFaltaAtraso = 0;
                    novo.TotalHora = totalLancamento;
                    codEmprendimento = LancamentoResult.codEmpredimento;
                    datalancamento = LancamentoResult.DateLancamento;
                    totalAbono = 0; totalLancamento = 0; totalHoraExedente = 0;
                    if (!Fechamento.Any(x => x.CodigoProjeto == LancamentoResult.codEmpredimento && x.DataLancamento == LancamentoResult.DateLancamento))
                        Fechamento.Add(novo);
                }



            }

            var listlancamentosSemMarcaco = ObterDiasSemLancamento(listlancamentoDiario.ToList(), _marcacao.ObterMarcacao(codmarcacao), filial, jornada);
            foreach (Fechamento fechamento in listlancamentosSemMarcaco)
            {
                fechamento.CodigoMarcacao = codmarcacao;
                fechamento.Filial = filial;
                fechamento.TotalAbono = 0;
                fechamento.TotalAtraso = 0;
                fechamento.TotalFalta = 0;
                fechamento.TotalFaltaAtraso = 0;
                fechamento.TotalHoraExedente = 0;
                fechamento.CodigoProjeto = "00000";
                fechamento.Fase = "0";
                fechamento.TotalHora = 0;
                fechamento.Divergencia = "0";
                Fechamento.Add(fechamento);
            }

            return Fechamento;
        }

        public double CalcularTotalGeral(List<Fechamento> listFecahamento)
        {
            double totalHorasFechamento = 0;
            double totalFaltaAtraso = 0;
            double totalAbono = 0;
            foreach (Fechamento fechamento in listFecahamento)
            {
                totalHorasFechamento += fechamento.TotalHora;
                totalFaltaAtraso += fechamento.TotalFaltaAtraso;
                totalAbono += fechamento.TotalAbono;
            }

            return totalHorasFechamento;
        }

        public double CalcularTotalExedenteGeral(List<Fechamento> listFecahamento)
        {
            double totalHorasExedente = 0;

            foreach (Fechamento fechamento in listFecahamento)
            {
                totalHorasExedente += fechamento.TotalHoraExedente;
            }
            return totalHorasExedente;
        }

        public double CalcularTotalNaoTrabalhadaGeral(List<Fechamento> listFecahamento)
        {
            double totalHorasNaoTrabalhada = 0;

            foreach (Fechamento fechamento in listFecahamento)
            {
                totalHorasNaoTrabalhada += fechamento.TotalFaltaAtraso;
            }
            return totalHorasNaoTrabalhada;
        }


        public double CalcularTotalAbonoGeral(List<Fechamento> listFecahamento)
        {
            double totalAbono = 0;

            foreach (Fechamento fechamento in listFecahamento)
            {
                totalAbono += fechamento.TotalAbono;
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

        public bool ESabadoOuDomingo(DateTime initialDate)
        {
            if (initialDate.DayOfWeek == DayOfWeek.Sunday
                   ||
                   initialDate.DayOfWeek == DayOfWeek.Saturday)
                return true;
            else return false;
        }

        public TimeSpan CalcularTotalHorasAbono(List<Lancamento> listlancamento)
        {
            TimeSpan totalAbono = TimeSpan.Parse("00:00:00");
            
            foreach (Lancamento lancamento in listlancamento)
            {
                if (lancamento.CodDivergencia != 0)
                {
                    var CodDivergencia = _serviceProthues.ObterTipoCodigoDivergencia(Convert.ToString(lancamento.CodDivergencia));
                    if(CodDivergencia != null) { 
                    if (CodDivergencia.Constant == Constantes.ABONOS)
                        totalAbono += lancamento.HoraFim - lancamento.HoraInicio;
                    }
                }

            }
            return totalAbono;
        }

        public TimeSpan CalcularTotalNaoTrabalhadas(List<Lancamento> listlancamento)
        {
            TimeSpan totalNaoTrabalhada = TimeSpan.Parse("00:00:00");
            foreach (Lancamento lancamento in listlancamento)
            {
                if (lancamento.CodDivergencia != 0)
                {
                    var CodDivergencia = _serviceProthues.ObterTipoCodigoDivergencia(Convert.ToString(lancamento.CodDivergencia));
                    if (CodDivergencia != null)
                    {
                        if (CodDivergencia.Constant == Constantes.NAOTRABALHADA)
                            totalNaoTrabalhada += lancamento.HoraFim - lancamento.HoraInicio;
                    }
                }
            }

            return totalNaoTrabalhada;
        }



        public double CalcularTotalHorasLancamentoPorProjeto(List<Lancamento> listlancamentoPorProjeto)
        {
            double totallancamento = 0;

            foreach (Lancamento lancamento in listlancamentoPorProjeto)
            {
                var CodDivergencia = _serviceProthues.ObterTipoCodigoDivergencia(Convert.ToString(lancamento.CodDivergencia));
                if (CodDivergencia != null)
                {
                    if (CodDivergencia.Constant != Constantes.NAOTRABALHADA)
                        totallancamento += Math.Round((lancamento.HoraFim - lancamento.HoraInicio).TotalHours, 2);
                }else if(lancamento.CodDivergencia == 0)
                {
                    totallancamento += Math.Round((lancamento.HoraFim - lancamento.HoraInicio).TotalHours, 2);
                }
            }
            return totallancamento;
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

        public Fechamento ValidaSemApontamentoRelogioExiste(List<Apontamento> listApontamento, string dataDia)
        {
            Fechamento novo = new Fechamento();
            if (listApontamento.Count == 0 & !ESabadoOuDomingo(Convert.ToDateTime(dataDia.ToDateProtheusReverseformate())))
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = dataDia.ToDateProtheusReverseformate();
                novo.Descricao = "Dia sem apontamento no relógio.";
                return novo;

            }
            return novo;
        }
    }

    public class FechamentoCompareCodProjetoExiste : IEqualityComparer<Fechamento>
    {
        public bool Equals(Fechamento x, Fechamento y) => x.DataLancamento == x.DataLancamento & x.CodigoProjeto == x.CodigoProjeto;
        public int GetHashCode(Fechamento obj) => obj.DataLancamento.GetHashCode() & obj.CodigoProjeto.GetHashCode();
    }
}
