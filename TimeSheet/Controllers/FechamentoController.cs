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
using System.Security.Claims;

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
        private readonly IFechamentoNegocio _fechamentoNegocio;
        private string filial;
        private string matricula;
        private string centrocusto;
   
        public FechamentoController(IFechamento fechamentoServiceRepository,
            IProtheus prothuesService,
            IMarcacao marcacaoServiceRepository,
            IMapper mapper,
            IConfiguracao configuracao,
            IMarcacao marcacao,
            ILancamento lancamento,
            IJornadaTrabalho jornada,
            INotificacao notificacao,
            IFluigAppService fluigAppService, ILancamentoNegocio lancamentoNegocio, IFechamentoNegocio fechamentoNegocio)
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
            _fechamentoNegocio = fechamentoNegocio;
        }

        public IActionResult Index()
        {
            try
            {
                var list = _mapper.Map<List<Marcacao>, List<ViewModelMacacao>>(_marcacaoServiceRepository.ObterListMarcacaoPorMatUser(matricula));
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
                matricula = User.GetDados("Matricula");
                filial = User.GetDados("Filial");
                centrocusto = User.GetDados("Centro de Custo");
              

                TempData["Createfalse"] = null;
                Marcacao marcacao = new Marcacao();
                Fechamento fechamento = new Fechamento();

                var ResultFechamento = ValidacaoFechamento(id);

                if (ResultFechamento.Count > 0)
                {
                    foreach (Fechamento fechamentoResult in ResultFechamento)
                    {
                        if (fechamentoResult.Divergencia == "Divergência a justificar")
                        {
                            ViewBag.FechamentoBloqueado = "B";
                            
                        }
                    }
                }
                ViewBag.CodigoMarcacao = id;
                ViewBag.Ferias = " ";
                return View("ValidarFechamento", _mapper.Map<List<ViewModelFechamento>>(ResultFechamento.OrderBy(c => c.DataLancamento)));
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }


        public IActionResult ConfirmacaoFerias(string id)
        {
            try
            {
                matricula = User.GetDados("Matricula");
                filial = User.GetDados("Filial");
                centrocusto = User.GetDados("Centro de Custo");


                TempData["Createfalse"] = null;
                Marcacao marcacao = new Marcacao();
                Fechamento fechamento = new Fechamento();

                var ResultFechamento = ValidacaoFechamento(id);


                if (ResultFechamento.Count > 0)
                {
                    foreach (Fechamento fechamentoResult in ResultFechamento)
                    {
                        if (fechamentoResult.Descricao == "Dia útil sem marcação.")
                        {
                            fechamentoResult.Divergencia = "Divergência justificada";
                            ViewBag.Ferias = "S";
                        }
                    }
                }

                if (ResultFechamento.Count > 0)
                {
                    foreach (Fechamento fechamentoResult in ResultFechamento)
                    {
                        if (fechamentoResult.Divergencia == "Divergência a justificar")
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

        [HttpPost]
        public IActionResult SalvarFerias(string CodMarcacao, string ConfirmacaoFerias)
        {
            try
            {
                if(ConfirmacaoFerias != null) {
                _marcacao.UpdateFerias(CodMarcacao, ConfirmacaoFerias);
                }
                return Json(new { erro = false });
            }
            catch (Exception e)
            {
                return Json(new { msg = e.Message, erro = true });
            }

        }

            public IActionResult ValidarFechamentoVisaoGerencia(string id)
        {
            try

            {
                Marcacao marcacao = new Marcacao();
                Fechamento fechamento = new Fechamento();

                marcacao = _marcacao.ObterMarcacao(id);
                filial = marcacao.Filial;
                matricula = marcacao.MatUsuario;
                centrocusto = User.GetDados("Centro de Custo");

                TempData["Createfalse"] = null;
                
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
                return View("ValidarFechamento");
            }

        }

        [HttpGet]
        public IActionResult Fechamento(string id)
        {
            try
            {
              
                Marcacao marcacao = new Marcacao();


                marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
                var listalancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());
                var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

                var configuracao = _configuracao.ObterConfiguracao();
                var viewModelFechamento = _mapper.Map<ViewModelFechamento>(_fechamentoNegocio.CalcularTotalGeralMensalPorDia(listalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho, configuracao, marcacao.MatUsuario, marcacao.Filial, id));
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
                List<Fechamento> listaCalculadaFechamentoPorProjeto = new List<Fechamento>();
                List<Fechamento> listaCalculadaFechamentoPorDia = new List<Fechamento>();
                List<Fechamento> listaDeDiasSemLancamento = new List<Fechamento>();
                Marcacao marcacao = new Marcacao();

                var Usuario = _fluigAppService.ObterUserCodFluig(User.GetClaim(ClaimTypes.Email));
                _fluigAppService.ValidarUserFluig(Usuario);

                marcacao = _marcacao.ObterMarcacao(viewModelfechamento.CodigoMarcacao);
                filial = marcacao.Filial;
                matricula = marcacao.MatUsuario;
                centrocusto = User.GetDados("Centro de Custo");

                marcacao.ValidaMarcacaoFoiFechada(_marcacaoServiceRepository.ObterMarcacao(viewModelfechamento.CodigoMarcacao));
                marcacao = _marcacaoServiceRepository.ObterMarcacao(viewModelfechamento.CodigoMarcacao);
                marcacao.Lancamentolist = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(viewModelfechamento.CodigoMarcacao, matricula);

                var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);
                var configuracao = _configuracao.ObterConfiguracao();
                string DataFechamento = String.Format("{0:MM/dd/yyyy}", DateTime.Now.ToString());


                listaCalculadaFechamentoPorProjeto = _fechamentoNegocio.CalcularLancamentoPorProjeto(marcacao.Lancamentolist, jornadaTrabalho, configuracao, matricula, filial, viewModelfechamento.CodigoMarcacao);
                _fechamentoServiceRepository.SalvarFechamentoPorProjeto(listaCalculadaFechamentoPorProjeto, filial, DataFechamento.ToDateProtheusConvert(), User.GetDados("Matricula"), centrocusto, "2");

                var listmacarcao = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(viewModelfechamento.CodigoMarcacao, matricula).Distinct(new LancamentoComparer());
                listaCalculadaFechamentoPorDia = _fechamentoNegocio.CalcularTotalHoraExedenteETrabalhadaEabonoeFaltaPorDia(listmacarcao.ToList(), configuracao, jornadaTrabalho, matricula, filial, viewModelfechamento.CodigoMarcacao);
                _fechamentoServiceRepository.SalvarFechamentoPorDia(listaCalculadaFechamentoPorDia, filial, DataFechamento.ToDateProtheusConvert(), User.GetDados("Matricula"), centrocusto, "2");
               
                 _marcacaoServiceRepository.UpdateStatusFechamento(viewModelfechamento.CodigoMarcacao);
                NotificarFechamento(viewModelfechamento);
                StartProcessoFluig(matricula, filial, viewModelfechamento.CodigoMarcacao);
                return Json(new { sucesso = "Fechamento realizado com sucesso! Processo do fluig foi aberto com sucesso! " });
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
           
            //Mit Validação 8.4.4.
            var listD = ValidaSabadoDomingoEFeriado(id);
            if (listD.Count > 0)
            {
               
            }

            //Mit Validação 8.4.1
            var listLancamento = ValidaDiasComLancameto(id);
            var listSemLancamento = ValidaDiasSemLancameto(id);

            foreach (Fechamento fechamentolist in listLancamento.OrderBy(x => x.DataLancamento))
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, fechamentolist.DataLancamento.ToDateProtheusConvert());
                var fechamentoReturn = _fechamentoNegocio.ValidarApontamentoImpar(fechamentolist, listApontamento);

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
                var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, fechamentolist.DataLancamento.ToDateProtheusConvert());
                var fechamentoReturn = _fechamentoNegocio.ValidarApontamentoImpar(fechamentolist, listApontamento);

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

            //Mit Validação 8.4.5 e  Validação 8.4.7.
            var listB = ValidaDiferencaBatida(id);
            if (listB.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listB.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                    {
                         
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




            //Mit Validação 8.4.8 e 8.4.9 e 8.4.10.
            var listF = ValidaLancamentoForaDeIntervalo(id);
            if (listF.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listF.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                    {
                                                      
                        listFechamento.Add(fechamentoResult);
                    }
                }

            }

            var listG = ValidaLancamentoForaDeIntervaloMinMax(id);
            if (listG.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listG.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                    {
                        listFechamento.Add(fechamentoResult);
                    }
                }

            }

            var DiasUteisSemLancamento = ValidaDiasSemLancameto(id);
            var listH = ValidaDiasSemApontamentoRelogio(id, DiasUteisSemLancamento);
            if (listH.Count > 0)
            {
                foreach (Fechamento fechamentoResult in listH.ToList())
                {
                    if (!VerificaSeDataEsabadoDomingoOUferiado(listD, fechamentoResult))
                    {
                        listFechamento.Add(fechamentoResult);
                    }
                }

            }

            return listFechamento;
        }

        private List<Fechamento> ValidarHorasExecedentesSemCodigoDivergencia(string id)
        {

            List<Fechamento> listFechamento = new List<Fechamento>();

            Marcacao marcacao = new Marcacao();
            marcacao = _marcacao.ObterMarcacao(id);
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

            foreach (Lancamento lancamento in listLancamento)
            {
                var lancamentolist = _lancamentoerviceRepository.ObterLancamento(lancamento.DateLancamento, matricula);
                var totalHoraExedenteComCodigo = _fechamentoNegocio.CalcularTotalHoraExedentes(lancamentolist);
                var totalHoraExedenteSemCodigo = _fechamentoNegocio.CalcularTotalHoraExedentesSemCodigo(lancamentolist, jornadaTrabalho);
                var FechamentoResultValidacao = _fechamentoNegocio.ValidarDiferencaHorasExcedentes(totalHoraExedenteComCodigo, totalHoraExedenteSemCodigo, lancamento.DateLancamento, jornadaTrabalho);

                if (FechamentoResultValidacao.Descricao != null)
                {
                    listFechamento.Add(FechamentoResultValidacao);
                }

            }
            return listFechamento;
        }

        private List<Fechamento> ValidaDiasSemApontamentoRelogio(string id, List<Fechamento> DiasUteisSemLancamento)
        {
            List<Fechamento> listFechamento = new List<Fechamento>();

            Marcacao marcacao = new Marcacao();
            marcacao = _marcacao.ObterMarcacao(id);
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

            foreach (Lancamento lancamento in listLancamento)
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, lancamento.DateLancamento);
                var FechamentoResultValidacao = _fechamentoNegocio.ValidaSemApontamentoRelogioExiste(listApontamento, lancamento.DateLancamento);

                if (FechamentoResultValidacao.Descricao != null)
                {
                    listFechamento.Add(FechamentoResultValidacao);
                }

            }

            foreach (Fechamento fechamento in DiasUteisSemLancamento)
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, fechamento.DataLancamento.ToDateProtheusConvert());
                var FechamentoResultValidacao = _fechamentoNegocio.ValidaSemApontamentoRelogioExiste(listApontamento, fechamento.DataLancamento.ToDateProtheusConvert());

                if (FechamentoResultValidacao.Descricao != null)
                {
                    listFechamento.Add(FechamentoResultValidacao);
                }

            }
            return listFechamento;
        }

        private List<Fechamento> ValidaLancamentoForaDeIntervaloMinMax(string id)
        {
            Fechamento fechamento = new Fechamento();
            List<Fechamento> listaFechamentoFinal = new List<Fechamento>();
            Marcacao marcacao = new Marcacao();

            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

            if (listLancamento != null)
            {

                foreach (Lancamento lancamento in listLancamento)
                {
                
                    var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(lancamento.DateLancamento, matricula);
                    var ListFechamento = _lancamentoNegocio.ValidaIntervaloMinimoEMaximo(LancamentoDiario.OrderBy(x=> x.HoraInicio).ToList(), jornadaTrabalho);

                    foreach(Fechamento fechamentoresult in ListFechamento)
                    {
                        if (fechamentoresult.Descricao != null)
                            listaFechamentoFinal.Add(fechamentoresult);
                    }
                }
            }
            return listaFechamentoFinal;
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
           
            List<Fechamento> listFechamento = new List<Fechamento>();

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

            foreach (Lancamento lancamento in listLancamento)
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, lancamento.DateLancamento);
                var lancamentolist = _lancamentoerviceRepository.ObterLancamento(lancamento.DateLancamento, matricula);
                var FechamentoResultValidacao = _fechamentoNegocio.ValidaSeExisteMarcacaoAntesEdepoisDoApontamento(lancamentolist.OrderBy(x=> x.HoraInicio).ToList(), listApontamento);
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

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

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

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, matricula).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).First();

            var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, LancamentoDiario.DateLancamento);
            var FechamentoResult = _fechamentoNegocio.ValidaPrimeiroLancamento(LancamentoDiario, listApontamento);

            return FechamentoResult;
        }

        private Fechamento ValidarUltimoLancamentoPorDia(string datalancamento)
        {
            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, matricula).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).Last();
            var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, LancamentoDiario.DateLancamento);
            var FechamentoResult = _fechamentoNegocio.ValidaUltimoLancamento(LancamentoDiario, listApontamento);

            return FechamentoResult;
        }

        private List<Fechamento> ValidaDiferencaTotalHoraLancamentoPorDiaETotalHoraJornadaDiaria(string id)
        {
           
            List<Fechamento> listFechamento = new List<Fechamento>();

            Marcacao marcacao = new Marcacao();
            marcacao = _marcacao.ObterMarcacao(id);
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

            foreach (Lancamento lancamento in listLancamento)
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, lancamento.DateLancamento);
                var lancamentolist = _lancamentoerviceRepository.ObterLancamento(lancamento.DateLancamento, matricula);
                var totalHoraDecimalLancamanetoPorDia = Math.Round(_fechamentoNegocio.CalcularTotalHoraLancamentoPorDia(lancamentolist).TotalHours,2);
                var FechamentoResultValidacao = _fechamentoNegocio.ValidaDiferencaEntreJornadaDiariaETotalLancamentoDiario(lancamentolist, Convert.ToDecimal(totalHoraDecimalLancamanetoPorDia), jornadaTrabalho);

                if (FechamentoResultValidacao.Descricao != null)
                {
                    listFechamento.Add(FechamentoResultValidacao);
                }

            }
            return listFechamento;
        }

        private List<Fechamento> ValidaSabadoDomingoEFeriado(string id)
        {
            List<Fechamento> listFechamento = new List<Fechamento>();

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());


            foreach (Lancamento lancamento in listLancamento)
            {
                var feriado = _prothuesService.ObterFeriadoPorDataLancamento(lancamento.DateLancamento, filial);
                var FechamentoResultValidacao = _fechamentoNegocio.ValidaSabadoDomingoFeriadoComApontamento(lancamento, feriado);

                if (FechamentoResultValidacao.Descricao != null)
                {
                    listFechamento.Add(FechamentoResultValidacao);
                }

            }
            return listFechamento;
        }


        private List<Fechamento> ValidaDiasSemLancameto(string id)
        {
            
            Marcacao marcacao = new Marcacao();

            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

            return _fechamentoNegocio.ValidaDiasSemLancamento(listLancamento.ToList(), marcacao, User.GetDados("Filial"));
        }
        private List<Fechamento> ValidaDiasComLancameto(string id)
        {
            Marcacao marcacao = new Marcacao();

            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

            return _fechamentoNegocio.ValidaDiasComLancamento(listLancamento.ToList(), marcacao,filial);
        }

        private List<Fechamento> ValidaLancamentoForaDeIntervalo(string id)
        {
            Fechamento fechamento = new Fechamento();
            List<Fechamento> listaFechamentoFinal = new List<Fechamento>();
            Marcacao marcacao = new Marcacao();

            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matricula).Distinct(new LancamentoComparer());

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

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento,matricula).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).First();

            var FechamentoResult = _fechamentoNegocio.ValidarLancamentoForaDeJornadaInicio(LancamentoDiario, jornada);

            return FechamentoResult;
        }


        private Fechamento ValidarUltimoLancamentoForaJornadaPorDia(string datalancamento, JornadaTrabalho jornada)
        {

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, matricula).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).LastOrDefault();

            var FechamentoResult = _fechamentoNegocio.ValidarUltimoLancamentoForaDeJornada(LancamentoDiario, jornada);

            return FechamentoResult;
        }

        private Fechamento ValidarPrimeiroLancamentoForaIntervaloPorDia(string datalancamento, JornadaTrabalho jornada)
        {

            var LancamentoDiario = _lancamentoerviceRepository.ObterLancamento(datalancamento, matricula).OrderBy(c => c.DateLancamento).OrderBy(h => h.HoraInicio).First();
            var FechamentoResult = _fechamentoNegocio.ValidarLancamentoForaDeIntervaloInicio(LancamentoDiario, jornada);

            return FechamentoResult;
        }

        private void NotificarFechamento(ViewModelFechamento fechamento)
        {
            var user = _prothuesService.ObterUsuarioNome(matricula);
            var coordenador = _prothuesService.ObterCoordenadorPorCentroDeCusto(User.GetDados("Centro de Custo"));
            var mensagem = $"{user.Nome}, realizou o fechamento da marcação: {fechamento.CodigoMarcacao}." + "\r\n" +
                           $"Matrícula : { matricula} ";
            _Notificacao.EnviarEmail(coordenador.Email, mensagem);

        }

        private void StartProcessoFluig(string matricula, string filial, string codMarcacao)
        {
            string[][] result;
            var Usuario = _fluigAppService.ObterUserCodFluig(User.GetClaim(ClaimTypes.Email));
            _fluigAppService.ValidarUserFluig(Usuario);
            var marcacao = _fluigAppService.ObterCodFluig(codMarcacao);
            if (_fluigAppService.ValidaNovoProcesso(marcacao))
            {
                var UsuarioGerencia = _fluigAppService.ObterUserGerencia(User.GetDados("Centro de Custo"));
                result = _fluigAppService.IniciarProcesso(Usuario.CodigoFluig, matricula, filial, UsuarioGerencia.Gerencia, codMarcacao, User.GetDados("Coordenacao"));
            }
            else
            {
                var UsuarioGerencia = _fluigAppService.ObterUserGerencia(User.GetDados("Centro de Custo"));
                _fluigAppService.RestartProcesso(Usuario.CodigoFluig, marcacao.CodigoFluig, matricula, filial, UsuarioGerencia.Gerencia, codMarcacao);
            }
            
        }

    }

    public class LancamentoComparer : IEqualityComparer<Lancamento>
    {
        public bool Equals(Lancamento x, Lancamento y) => x.DateLancamento == y.DateLancamento;
        public int GetHashCode(Lancamento obj) => obj.DateLancamento.GetHashCode();
    }
}