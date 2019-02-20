using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TimeSheet.Application;
using TimeSheet.Application.Interface;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.Util;
using TimeSheet.ViewModel;


namespace TimeSheet.Controllers
{
    [Authorize]
    public class FechamentoController : Controller
    {
        private readonly IProtheus _prothuesService;
        private readonly IConfiguracao _configuracao;
        private readonly IMarcacao _marcacao;
        private readonly ILancamento _lancamentoerviceRepository;
        private readonly IMarcacao _marcacaoServiceRepository;
        private readonly IMapper _mapper;
        private readonly IJornadaTrabalho _jornadaTrbServiceRepository;
        private readonly IFechamento _fechamentoServiceRepository;
        private readonly INotificacao _Notificacao;
        private readonly IFluigAppService _fluigAppService;
        private readonly ILancamentoNegocio _lancamentoNegocio;

        public FechamentoController(IFechamento fechamentoServiceRepository,
            IProtheus prothuesService,
            IMarcacao marcacaoServiceRepository,
            IMapper mapper,
            IConfiguracao configuracao,
            IMarcacao marcacao,
            ILancamento lancamento,
            IJornadaTrabalho jornada,
            INotificacao notificacao,
            IFluigAppService fluigAppService, ILancamentoNegocio lancamentoNegocio)
        {
            _prothuesService = prothuesService;
            _marcacaoServiceRepository = marcacaoServiceRepository;
            _mapper = mapper;
            _configuracao = configuracao;
            _marcacao = marcacao;
            _lancamentoerviceRepository = lancamento;
            _jornadaTrbServiceRepository = jornada;
            _fechamentoServiceRepository = fechamentoServiceRepository;
            _Notificacao = notificacao;
            _fluigAppService = fluigAppService;
            _lancamentoNegocio = lancamentoNegocio;
        }

        public IActionResult Index()
        {
            try
            {
                var list = _mapper.Map<List<Marcacao>, List<ViewModelMacacao>>(_marcacaoServiceRepository.ObterListMarcacaoPorMatUser(User.GetDados("Matricula")));
                if (list.Count > 0)
                {
                    foreach (var lista in list)
                    {
                        var mes = lista.AnoMes.ToString().Substring(4, 2);
                        var ano = lista.AnoMes.ToString().Substring(0, 4);
                        string month = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(Convert.ToInt32(mes));
                        lista.AnoMesDescricao = char.ToUpper(month[0]) + month.Substring(1) + "/" + ano;
                    }

                }
                return View(list);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }

        public IActionResult ValidarFechamento(string id)
        {
            try
            {
                TempData["Createfalse"] = null;
                Marcacao marcacao = new Marcacao();
                Fechamento fechamento = new Fechamento();

                var ResultFechamento = ValidacaoFechamento(id);

                if (ResultFechamento.Count > 0)
                {
                    foreach (Fechamento fechamentoResult in ResultFechamento)
                    {
                        if (fechamentoResult.StatusFechamento == "B")
                        {
                            ViewBag.FechamentoBloqueado = "B";
                        }
                    }
                }
                ViewBag.CodigoMarcacao = id;
                return View("ValidarFechamento", _mapper.Map<List<ViewModelFechamento>>(ResultFechamento.OrderBy(c => c.DataLancamento)));
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }



        [HttpGet]
        public IActionResult Fechamento(string id)
        {
            try
            {
                FechamentoNegocio fechamento = new FechamentoNegocio();
                Marcacao marcacao = new Marcacao();


                marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
                marcacao.Lancamentolist = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula"));
                var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

                var configuracao = _configuracao.ObterConfiguracao();
                var viewModelFechamento = _mapper.Map<ViewModelFechamento>(fechamento.CalcularFechamento(marcacao.Lancamentolist.OrderBy(c => c.DateLancamento), jornadaTrabalho, configuracao));
                viewModelFechamento.CodigoMarcacao = id;
                return View("Fechamento", viewModelFechamento);
            }
            catch (Exception e)
            {
                return Json(new
                {
                    msg = e.Message,
                    erro = true
                });
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Fechamento(ViewModelFechamento viewModelfechamento)
        {
            try
            {
                List<Fechamento> listaFechamentoPorData = new List<Fechamento>();
                List<Fechamento> listaDeDiasSemLancamento = new List<Fechamento>();
                Marcacao marcacao = new Marcacao();

                marcacao.ValidaMarcacaoFoiFechada(_marcacaoServiceRepository.ObterMarcacao(viewModelfechamento.CodigoMarcacao));
                marcacao = _marcacaoServiceRepository.ObterMarcacao(viewModelfechamento.CodigoMarcacao);
                marcacao.Lancamentolist = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(viewModelfechamento.CodigoMarcacao, User.GetDados("Matricula"));

                var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);
                var configuracao = _configuracao.ObterConfiguracao();

                listaFechamentoPorData = _lancamentoNegocio.CalcularLancamentoPorData(marcacao.Lancamentolist, jornadaTrabalho, configuracao, User.GetDados("Matricula"), User.GetDados("Filial"));


                string DataFechamento = String.Format("{0:MM/dd/yyyy}", DateTime.Now.ToString());

                _fechamentoServiceRepository.SalvarFechamentoPorDiaLancamento(listaFechamentoPorData, User.GetDados("Filial"), DataFechamento.ToDateProtheusConvert(), User.GetDados("Matricula"), User.GetDados("Centro de Custo"), "2");
                _marcacaoServiceRepository.UpdateStatusFechamento(viewModelfechamento.CodigoMarcacao);
                NotificarFechamento(viewModelfechamento);
                return Json(new { sucesso = "Fechamento realizado com sucesso!" });
            }
            catch (Exception e)
            {
                return Json(new
                {
                    msg = e.Message,
                    erro = true
                });
            }

        }



        public List<Fechamento> ValidacaoFechamento(string id)
        {
            List<Fechamento> listFechamento = new List<Fechamento>();
            FechamentoNegocio fechamento = new FechamentoNegocio();

            //Mit Validação 8.4.4 erro não concluirá o fechamento caso possuir divergências.
            var listD = ValidaSabadoDomingoEFeriado(id);
            if (listD.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listD.ToList())
                {
                    listFechamento.Add(fechamentoResult);
                }
            }

            //Mit Validação 8.4.1
            var listLancamento = ValidaDiasComLancameto(id);
            var listSemLancamento = ValidaDiasSemLancameto(id);

            foreach (Fechamento fechamentolist in listLancamento.OrderBy(x => x.DataLancamento))
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), fechamentolist.DataLancamento.ToDateProtheusConvert());
                var fechamentoReturn = fechamento.ValidarApontamentoImpar(fechamentolist, listApontamento);

                if (fechamentoReturn.Divergencia != null)
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentolist))
                    {
                        Fechamento novoFechamento = new Fechamento();
                        novoFechamento = fechamentoReturn;
                        listFechamento.Add(novoFechamento);
                    }
                }

            }
            //Mit Validação 8.4.1
            foreach (Fechamento fechamentolist in listSemLancamento.OrderBy(x => x.DataLancamento))
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), fechamentolist.DataLancamento.ToDateProtheusConvert());
                var fechamentoReturn = fechamento.ValidarApontamentoImpar(fechamentolist, listApontamento);

                if (fechamentoReturn.Divergencia != null)
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentolist))
                    {
                        Fechamento novoFechamento = new Fechamento();
                        novoFechamento = fechamentoReturn;
                        listFechamento.Add(novoFechamento);
                    }
                }

            }

            //Mit Validação 8.4.2   
            var listA = ValidaDiferencaTotalHoraDiaLancamentoMacacao(id);
            if (listA.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listA.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                        listFechamento.Add(fechamentoResult);
                }
            }

            //Mit Validação 8.4.3
            var listE = ValidaDiasSemLancameto(id);
            if (listE.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listE.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                        listFechamento.Add(fechamentoResult);
                }
            }

            //Mit Validação 8.4.5 e  Validação 8.4.7 não concluirá o fechamento caso possuir divergências.
            var listB = ValidaDiferencaBatida(id);
            if (listB.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listB.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                    {
                        fechamentoResult.StatusFechamento = "B";  // status bloqueado para fechamento caso exista.
                        listFechamento.Add(fechamentoResult);
                    }
                }
            }


            //Mit Validação 8.4.8  a  Validação 8.4.10
            var listC = ValidaDiferencaTotalHoraLancamentoPorDiaETotalHoraJornadaDiaria(id);
            if (listC.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listC.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                        listFechamento.Add(fechamentoResult);
                }
            }




            //Mit Validação 8.4.8 e 8.4.9 e 8.4.10 não concluirá o fechamento caso possuir divergências.
            var listF = ValidaLancamentoForaDeIntervalo(id);
            if (listF.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listF.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                    {
                        fechamentoResult.StatusFechamento = "B";  // status bloqueado para fechamento caso exista.
                        listFechamento.Add(fechamentoResult);
                    }
                }

            }

            return listFechamento;
        }

        private bool VerificaSeDataEsabadoDomingoOUferiado(List<Fechamento> listafechamento, Fechamento fechamentoCompara)
        {
            foreach (Fechamento fechamento in listafechamento)
            {
                if (fechamento.DataLancamento == fechamentoCompara.DataLancamento)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private List<Fechamento> ValidaDiferencaTotalHoraDiaLancamentoMacacao(string id)
        {
            FechamentoNegocio fechamento = new FechamentoNegocio();
            List<Fechamento> listFechamento = new List<Fechamento>();

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());

            foreach (Lancamento lancamento in listLancamento)
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), lancamento.DateLancamento);
                var lancamentolist = _lancamentoerviceRepository.ObterLancamento(lancamento.DateLancamento, User.GetDados("Matricula"));
                var FechamentoResultValidacao = fechamento.ValidaSeExisteMarcacaoAntesEdepoisDoApontamento(lancamentolist, listApontamento);
                foreach (Fechamento LancamentoResult in FechamentoResultValidacao)
                {
                    if (LancamentoResult.Descricao != null)
                    {
                        listFechamento.Add(LancamentoResult);
                    }
                }

            }
            return listFechamento;
        }


        private List<Fechamento> ValidaDiferencaBatida(string id)
        {
            Fechamento fechamento = new Fechamento();
            List<Fechamento> listaFechamentoFinal = new List<Fechamento>();

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());

            if (listLancamento != null)
            {

                foreach (Lancamento lancamento in listLancamento)
                {
                    var fechamentoRetornoPrimeiro = ValidarPrimeiroLancamentoPorDia(lancamento.DateLancamento);
                    var fechamentoRetornoUltimo = ValidarUltimoLancamentoPorDia(lancamento.DateLancamento);

                    if (fechamentoRetornoPrimeiro.Descricao != null)
                    {
                        Fechamento novoFechamento = new Fechamento();
                        novoFechamento = fechamentoRetornoPrimeiro;
                        listaFechamentoFinal.Add(novoFechamento);
                    }
                    if (fechamentoRetornoUltimo.Descricao != null)
                    {
                        Fechamento novoFechamento = new Fechamento();
                        novoFechamento = fechamentoRetornoUltimo;
                        listaFechamentoFinal.Add(novoFechamento);
                    }

                }
            }
            return listaFechamentoFinal;
        }


        private Fechamento ValidarPrimeiroLancamentoPorDia(string datalancamento)
        {
            FechamentoNegocio fechamento = new FechamentoNegocio();

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, User.GetDados("Matricula")).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).First();

            var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), LancamentoDiario.DateLancamento);
            var FechamentoResult = fechamento.ValidaPrimeiroLancamento(LancamentoDiario, listApontamento);

            return FechamentoResult;
        }

        private Fechamento ValidarUltimoLancamentoPorDia(string datalancamento)
        {
            FechamentoNegocio fechamento = new FechamentoNegocio();

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, User.GetDados("Matricula")).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).Last();
            var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), LancamentoDiario.DateLancamento);
            var FechamentoResult = fechamento.ValidaUltimoLancamento(LancamentoDiario, listApontamento);

            return FechamentoResult;
        }

        private List<Fechamento> ValidaDiferencaTotalHoraLancamentoPorDiaETotalHoraJornadaDiaria(string id)
        {
            FechamentoNegocio fechamento = new FechamentoNegocio();
            List<Fechamento> listFechamento = new List<Fechamento>();

            Marcacao marcacao = new Marcacao();
            marcacao = _marcacao.ObterMarcacao(id);
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());

            foreach (Lancamento lancamento in listLancamento)
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), lancamento.DateLancamento);
                var lancamentolist = _lancamentoerviceRepository.ObterLancamento(lancamento.DateLancamento, User.GetDados("Matricula"));
                var totalHoraDecimalLancamanetoPorDia = fechamento.CalcularTotalHoraLancamentoPorDia(lancamentolist);
                var FechamentoResultValidacao = fechamento.ValidaDiferencaEntreJornadaDiariaETotalLancamentoDiario(lancamento, totalHoraDecimalLancamanetoPorDia, jornadaTrabalho);

                if (FechamentoResultValidacao.Descricao != null)
                {
                    listFechamento.Add(FechamentoResultValidacao);
                }

            }
            return listFechamento;
        }

        private List<Fechamento> ValidaSabadoDomingoEFeriado(string id)
        {
            FechamentoNegocio fechamento = new FechamentoNegocio();
            List<Fechamento> listFechamento = new List<Fechamento>();

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());


            foreach (Lancamento lancamento in listLancamento)
            {
                var feriado = _prothuesService.ObterFeriadoPorDataLancamento(lancamento.DateLancamento, User.GetDados("Filial"));
                var FechamentoResultValidacao = fechamento.ValidaSabadoDomingoFeriadoComApontamento(lancamento, feriado);

                if (FechamentoResultValidacao.Descricao != null)
                {
                    listFechamento.Add(FechamentoResultValidacao);
                }

            }
            return listFechamento;
        }


        private List<Fechamento> ValidaDiasSemLancameto(string id)
        {
            FechamentoNegocio fechamentoNegocio = new FechamentoNegocio();
            Marcacao marcacao = new Marcacao();

            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());

            return fechamentoNegocio.ValidaDiasSemLancamento(listLancamento.ToList(), marcacao, User.GetDados("Filial"));
        }
        private List<Fechamento> ValidaDiasComLancameto(string id)
        {
            FechamentoNegocio fechamentoNegocio = new FechamentoNegocio();
            Marcacao marcacao = new Marcacao();

            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());

            return fechamentoNegocio.ValidaDiasComLancamento(listLancamento.ToList(), marcacao, User.GetDados("Filial"));
        }

        private List<Fechamento> ValidaLancamentoForaDeIntervalo(string id)
        {
            Fechamento fechamento = new Fechamento();
            List<Fechamento> listaFechamentoFinal = new List<Fechamento>();
            Marcacao marcacao = new Marcacao();

            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());

            if (listLancamento != null)
            {

                foreach (Lancamento lancamento in listLancamento)
                {
                    var fechamentoRetornoPrimeiro = ValidarPrimeiroLancamentoForaJornadaPorDia(lancamento.DateLancamento, jornadaTrabalho);
                    var fechamentoRetornoUltimo = ValidarUltimoLancamentoForaJornadaPorDia(lancamento.DateLancamento, jornadaTrabalho);
                    var fechamentoRetornoForaIntervalo = ValidarPrimeiroLancamentoForaIntervaloPorDia(lancamento.DateLancamento, jornadaTrabalho);

                    if (fechamentoRetornoPrimeiro.Descricao != null)
                    {
                        Fechamento novo = new Fechamento();
                        novo = fechamentoRetornoPrimeiro;
                        listaFechamentoFinal.Add(novo);
                    }
                    if (fechamentoRetornoUltimo.Descricao != null)
                    {
                        Fechamento novo = new Fechamento();
                        novo = fechamentoRetornoUltimo;
                        listaFechamentoFinal.Add(novo);
                    }
                    if (fechamentoRetornoForaIntervalo.Descricao != null)
                    {
                        Fechamento novo = new Fechamento();
                        novo = fechamentoRetornoForaIntervalo;
                        listaFechamentoFinal.Add(novo);
                    }

                }
            }
            return listaFechamentoFinal;
        }


        private Fechamento ValidarPrimeiroLancamentoForaJornadaPorDia(string datalancamento, JornadaTrabalho jornada)
        {
            FechamentoNegocio fechamento = new FechamentoNegocio();

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, User.GetDados("Matricula")).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).First();

            var FechamentoResult = fechamento.ValidarLancamentoForaDeJornadaInicio(LancamentoDiario, jornada);

            return FechamentoResult;
        }


        private Fechamento ValidarUltimoLancamentoForaJornadaPorDia(string datalancamento, JornadaTrabalho jornada)
        {
            FechamentoNegocio fechamento = new FechamentoNegocio();

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, User.GetDados("Matricula")).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).LastOrDefault();

            var FechamentoResult = fechamento.ValidarUltimoLancamentoForaDeJornada(LancamentoDiario, jornada);

            return FechamentoResult;
        }

        private Fechamento ValidarPrimeiroLancamentoForaIntervaloPorDia(string datalancamento, JornadaTrabalho jornada)
        {
            FechamentoNegocio fechamento = new FechamentoNegocio();

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, User.GetDados("Matricula")).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).First();
            var FechamentoResult = fechamento.ValidarLancamentoForaDeIntervaloInicio(LancamentoDiario, jornada);

            return FechamentoResult;
        }

        private void NotificarFechamento(ViewModelFechamento fechamento)
        {
            var user = _prothuesService.ObterUsuarioNome(User.GetDados("Matricula"));
            var coordenador = _prothuesService.ObterCoordenadorPorCentroDeCusto(User.GetDados("Centro de Custo"));
            var mensagem = $"{user.Nome}, realizou o fechamento da marcação: {fechamento.CodigoMarcacao}." + "\r\n" +
                           $"Matrícula : {User.GetDados("Matricula")} ";
            _Notificacao.EnviarEmail(coordenador.Email, mensagem);

        }

        private void StartProcessoFluig(string userCodFluig, string matricula, string filial, string projeto, string GrupoGerencia, string PoolGrupo)
        {
            _fluigAppService.IniciarProcesso(userCodFluig, matricula, filial, projeto, GrupoGerencia, PoolGrupo);
        }


    }

    public class LancamentoComparer : IEqualityComparer<Lancamento>
    {
        public bool Equals(Lancamento x, Lancamento y) => x.DateLancamento == y.DateLancamento;
        public int GetHashCode(Lancamento obj) => obj.DateLancamento.GetHashCode();
    }
}