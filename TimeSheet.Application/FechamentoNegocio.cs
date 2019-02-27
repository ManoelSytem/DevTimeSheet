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

            listaFechamentoPorData = CalcularTotalLancamentoPorProjeto(orderedlistalancamento.OrderBy(x => x.DateLancamento).ToList(),matricula, jornadaTrabalho, configura, filial, codmarcacao);
            return listaFechamentoPorData;
        }

        public Fechamento CalcularFechamento(IOrderedEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho, Configuracao configura)
        {
            Fechamento Fechamento = new Fechamento();
            Fechamento.TotalHoraExedente = Math.Round(CalcularTotalHoraExedente(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            Fechamento.TotalAtraso = Math.Round(CalcularAtraso(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            Fechamento.TotalFalta = CalcularQuantidadeDeDiaSemApontamento(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho);
            Fechamento.TotalAbono = CalcularTotalDeAbono(orderedlistalancamento.OrderBy(c => c.DateLancamento), configura);
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

        //Inicio das validações de acordo com a MIT
        public Fechamento ValidarApontamentoImpar(Fechamento fechamento, List<Apontamento> apontamento)
        {
            Fechamento novoFechamento = new Fechamento();

            if (VerificaImpar(apontamento))
            {
                novoFechamento.Divergencia = "Divergência justificada";
                novoFechamento.DataLancamento = fechamento.DataLancamento;
                novoFechamento.Descricao = "Dia com quantidade de batidas do relógio impar";
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

        public decimal CalcularTotalHoraLancamentoPorDia(List<Lancamento> lancamento)
        {
            TimeSpan totalhoraLancamentoDia = TimeSpan.Parse("00:00:00");
            foreach (Lancamento LancamentoResult in lancamento)
            {
                if (LancamentoResult.CodDivergencia != 0)
                {
                    totalhoraLancamentoDia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
                }
                else
                {
                    totalhoraLancamentoDia += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
                }
            }
            return Math.Round(Convert.ToDecimal(totalhoraLancamentoDia.TotalHours), 2);
        }

        public List<Fechamento> ValidaSeExisteMarcacaoAntesEdepoisDoApontamento(List<Lancamento> listlancamento, List<Apontamento> apontamentolist)
        {
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
                                novo.Descricao = "Dia com diferença entre o total de horas apontado pelas batidas do relógio e pela marcações no sistema";
                                
                            }
                            else if ((listlancamento.FirstOrDefault().HoraInicio < apontamentolist.FirstOrDefault().apontamento | listlancamento.FirstOrDefault().HoraFim > apontamentolist.LastOrDefault().apontamento) && listlancamento.FirstOrDefault().CodDivergencia != 0)
                            {
                                novo.Divergencia = "Divergência justificada";
                                novo.DataLancamento = listlancamento.FirstOrDefault().DateLancamento.ToDateProtheusReverseformate();
                                novo.Descricao = "Dia com diferença entre o total de horas apontado pelas batidas do relógio e pela marcações no sistema";
                               
                            }

                            if ((listlancamento.LastOrDefault().HoraFim < apontamentolist.LastOrDefault().apontamento) && listlancamento.LastOrDefault().CodDivergencia == 0)
                            {
                                novo.Divergencia = "Divergência a justificar";
                                novo.DataLancamento = listlancamento.LastOrDefault().DateLancamento.ToDateProtheusReverseformate();
                                novo.Descricao = "Dia com diferença entre o total de horas apontado pelas batidas do relógio e pela marcações no sistema";
                                

                            }
                            else if ((listlancamento.LastOrDefault().HoraFim < apontamentolist.LastOrDefault().apontamento) && listlancamento.LastOrDefault().CodDivergencia != 0)
                            {
                               
                                novo.Divergencia = "Divergência justificada";
                                novo.DataLancamento = listlancamento.LastOrDefault().DateLancamento.ToDateProtheusReverseformate();
                                novo.Descricao = "Dia com diferença entre o total de horas apontado pelas batidas do relógio e pela marcações no sistema";
                               
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
            if (!VerificaImpar(apontamentolist))
            {
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
                        novo.Descricao = "Dia com diferença entre a primeira batida do relógio e o primeiro lançamento no sistema e sem código de divergência";
                        return novo;
                    }
                    break;
                }
            }
            return FechamentoRetorno;
        }


        public Fechamento ValidaUltimoLancamento(Lancamento lancamento, List<Apontamento> apontamentolist)
        {
            var mensagem = "Dia com diferença entre a última batida do relógio e o último lançamento no sistema.";
            if (apontamentolist.Count > 0)
            {
                if ((lancamento.HoraFim > apontamentolist.LastOrDefault().horaFim | lancamento.HoraFim < apontamentolist.LastOrDefault().horaFim) && lancamento.CodDivergencia == 0)
                {
                    mensagem = "Dia com diferença entre a última batida do relógio e o último lançamento no sistema.";

                    return new Fechamento()
                    {
                        Divergencia = "Divergência a justificar",
                        DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate(),
                        Descricao = mensagem
                    };

                }
                else if ((lancamento.HoraFim > apontamentolist.LastOrDefault().horaFim | lancamento.HoraFim < apontamentolist.LastOrDefault().horaFim) && lancamento.CodDivergencia != 0)
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

        public Fechamento ValidaDiferencaEntreJornadaDiariaETotalLancamentoDiario(Lancamento lancamento, decimal totalLancamento, JornadaTrabalho jornada)
        {
            Fechamento novo = new Fechamento();
            if (totalLancamento < Math.Round(Convert.ToDecimal(jornada.JornadaDiaria.TotalHours), 2) )
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Dia com diferença entre o total apontado e a jornada diária";
            }
            else if (totalLancamento > Math.Round(Convert.ToDecimal(jornada.JornadaDiaria.TotalHours), 2))
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Dia com diferença entre o total apontado e a jornada diária";
            }

            return novo;
        }

        public Fechamento ValidaSabadoDomingoFeriadoComApontamento(Lancamento lancamento, Feriado feriado)
        {
            Fechamento novo = new Fechamento();

            if ((Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Sunday |
               Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Saturday | feriado.Descricao != null) && lancamento.CodDivergencia == 0)
            {
                novo.Divergencia = "Divergência a justificar";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Sábados, domingos e feriados com lançamento e sem código de divergência";

            }
            if ((Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Sunday |
               Convert.ToDateTime(lancamento.DateLancamento.ToDateProtheusReverseformate()).DayOfWeek == DayOfWeek.Saturday | feriado.Descricao != null) && lancamento.CodDivergencia != 0)
            {
                novo.Divergencia = "Divergência justificada";
                novo.DataLancamento = lancamento.DateLancamento.ToDateProtheusReverseformate();
                novo.Descricao = "Sábados, domingos e feriados com lançamentos";

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
        public List<Fechamento> CalcularTotalHoraExedenteETrabalhadaEabonoeFaltaPorDia(JornadaTrabalho jornada, string matricula, string filial, string codmarcacao)
        {
            List<Fechamento> listFechamentoCalculadaPorDia = new List<Fechamento>();

            var listFechamento = _fechamentoServiceRepository.ObterListFechamentoMensalPorMarcacaoDataColoborador(matricula, codmarcacao);
            var marcacao = _marcacao.ObterMarcacao(codmarcacao);


                foreach (Fechamento FechamentoResult in listFechamento)
                {
                    Fechamento novo = new Fechamento();
                    novo.DataLancamento = FechamentoResult.DataLancamento;
                    novo.CodigoProjeto = "00000";
                    novo.CodigoMarcacao = codmarcacao;
                    novo.TotalHora = FechamentoResult.TotalHora;
                    novo.TotalFaltaAtraso = 0;
                    if (FechamentoResult.TotalHora > Math.Round(Convert.ToDouble(jornada.JornadaDiaria.TotalHours), 2)) novo.TotalHoraExedente = Math.Round(FechamentoResult.TotalHora - Math.Round(Convert.ToDouble(jornada.JornadaDiaria.TotalHours), 2), 2);
                    else { novo.TotalHoraExedente = 0; novo.TotalFaltaAtraso =  Math.Round(Convert.ToDouble(jornada.JornadaDiaria.TotalHours), 2) - FechamentoResult.TotalHora; }
                    novo.Fase = "0";
                    novo.TotalAbono = FechamentoResult.TotalAbono;
                    listFechamentoCalculadaPorDia.Add(novo);
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
                           totalAbono += CalcularTotalHorasAbono(listaPorEmprendimentoDia, config);
                           totalLancamento += CalcularTotalHorasLancamentoPorProjeto(listaPorEmprendimentoDia);
                       
                            Fechamento novo = new Fechamento();
                            novo.DataLancamento = LancamentoResult.DateLancamento;
                            novo.CodigoProjeto = LancamentoResult.codEmpredimento;
                            novo.CodigoMarcacao = codmarcacao;
                            novo.Fase = LancamentoResult.Fase;
                            if (Eabono(LancamentoResult, config)) novo.TotalAbono = totalAbono;
                            if (ValidaEferiado(LancamentoResult.DateLancamento, filial) | ESabadoOuDomingo(Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate())))
                            {
                                novo.TotalHoraExedente = totalLancamento;
                            }
                            else if(totalLancamento > Math.Round(Convert.ToDouble(jrDiaria.TotalHours), 2)) totalHoraExedente = Math.Round(totalLancamento - Math.Round(Convert.ToDouble(jrDiaria.TotalHours), 2),2);
                            else { novo.TotalHoraExedente = 0; novo.TotalFaltaAtraso = 0; }
                            novo.TotalHora = totalLancamento;
                            codEmprendimento = LancamentoResult.codEmpredimento;
                            datalancamento = LancamentoResult.DateLancamento;
                            totalAbono = 0; totalLancamento = 0; totalHoraExedente = 0;
                            if(!Fechamento.Any(x => x.CodigoProjeto == LancamentoResult.codEmpredimento && x.DataLancamento == LancamentoResult.DateLancamento))
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
                fechamento.TotalFaltaAtraso = Math.Round(Convert.ToDouble(jrDiaria.TotalHours), 2);
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
                    &&
                   initialDate.DayOfWeek == DayOfWeek.Saturday)
                return true;
            else return false;
        }

        public double CalcularTotalHorasAbono(List<Lancamento> listlancamentoPorProjeto, Configuracao config)
        {
            double totalAbono = 0;

            foreach(Lancamento lancamento in listlancamentoPorProjeto) { 
            if (lancamento.CodDivergencia != 0)
                totalAbono+= Math.Round((lancamento.HoraFim - lancamento.HoraInicio).TotalHours, 2);
            }
            return totalAbono;
        } 

        public double CalcularTotalHorasLancamentoPorProjeto(List<Lancamento> listlancamentoPorProjeto)
        {
            double totallancamento = 0;

            foreach (Lancamento lancamento in listlancamentoPorProjeto)
            {
                totallancamento += Math.Round((lancamento.HoraFim - lancamento.HoraInicio).TotalHours, 2);
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
    }

    public class FechamentoCompareCodProjetoExiste : IEqualityComparer<Fechamento>
    {
        public bool Equals(Fechamento x, Fechamento y) => x.DataLancamento == x.DataLancamento & x.CodigoProjeto == x.CodigoProjeto;
        public int GetHashCode(Fechamento obj) => obj.DataLancamento.GetHashCode() & obj.CodigoProjeto.GetHashCode();
    }
}
