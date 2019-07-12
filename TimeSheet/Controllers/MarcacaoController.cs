using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using TimeSheet.Application;
using TimeSheet.Application.Interface;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.Util;
using TimeSheet.ViewModel;


namespace TimeSheet.Controllers
{
    [Authorize]
    public class MarcacaoController : Controller
    {
        private readonly IProtheus _prothuesService;
        private readonly IConfiguracao _configuracao;
        private readonly IMarcacao _marcacao;
        private readonly ILancamento _lancamentoerviceRepository;
        private readonly IMarcacao _marcacaoServiceRepository;
        private readonly IMapper _mapper;
        private readonly IJornadaTrabalho _jornadaTrbServiceRepository;
        private readonly IJornadaTrabalhoNegocio _jornadaTrbNegocio;

        Configuracao config;
        Marcacao marcacao;
        public MarcacaoController(IJornadaTrabalhoNegocio jornadaTrabalhoNegocio, IProtheus prothuesService, IMarcacao marcacaoServiceRepository, IMapper mapper, IConfiguracao configuracao, IMarcacao marcacao, ILancamento lancamento, IJornadaTrabalho jornada)
        {
            _jornadaTrbNegocio = jornadaTrabalhoNegocio;
            _prothuesService = prothuesService;
            _marcacaoServiceRepository = marcacaoServiceRepository;
            _mapper = mapper;
            _configuracao = configuracao;
            _marcacao = marcacao;
            _lancamentoerviceRepository = lancamento;
            _jornadaTrbServiceRepository = jornada;

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
                        lista.DataDialancamento = Convert.ToDateTime(lista.DataInicio.ToDateProtheusReverseformate());
                    }
                }

                var listOrdenada = list.OrderByDescending(d => d.DataDialancamento).ToList();
                return View(listOrdenada);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }

        public IActionResult Create()
        {
            try
            {
                var infoUser = new ViewModelMacacao();
                var user = new Usuario();
                infoUser.MatUsuario = User.GetDados("Matricula");
                infoUser.Coordenacao = User.GetDados("Coordenacao");
                user = _prothuesService.ObterUsuarioNome(User.GetDados("Matricula"));
                infoUser.NomeUsuario = user.Nome;
                return View(infoUser);

            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ViewModelMacacao marcacao)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Marcacao aberturaMarcacao = new Marcacao();
                    ViewModelLancamento lancamento = new ViewModelLancamento();
                    JornadaTrabalho jornada = new JornadaTrabalho();
                    CodDivergenciaViewModel codiv = new CodDivergenciaViewModel();
                    if (marcacao.DataDialancamento != null)
                    {
                        marcacao.DataDia = marcacao.DataDialancamento?.ToString("yyyy-MM-dd");
                    }
                    string codigoAbertura = aberturaMarcacao.AbeturaExiste(_marcacao.ObterListMarcacaoPorMatUser(User.GetDados("Matricula")), marcacao.DataDia.ToDia(), marcacao.DataDia.ToAno());
                    string codJornadaTrabalho = jornada.ValidarJornadaTrabalhoExisteParaLancamento(_jornadaTrbServiceRepository.ObterListJornada(), marcacao.DataDia.ToDateProtheusReverse());
                   
                    if (codigoAbertura == "0")
                    {
                        var configuracao = _configuracao.ObterConfiguracao();
                        marcacao.DataInicio = ObterPrimeiroDia(configuracao, marcacao);
                        marcacao.DataFim = ObterDiaFim(configuracao, marcacao);
                        marcacao.AnoMes = marcacao.DataDia.ToShortDateProtheus();
                        marcacao.MatUsuario = User.GetDados("Matricula");
                        marcacao.Filial = User.GetDados("Filial");
                        marcacao.Status = Constantes.ABERTO;
                        marcacao.codigojornada = codJornadaTrabalho;
                        _marcacao.SalvarMarcacao(_mapper.Map<Marcacao>(marcacao));
                    }

                    if (marcacao.Lancamento != null)
                    {
                        marcacao.Lancamento.ValidaHoraLancamento();
                        marcacao.Lancamento.Observacao = marcacao.Lancamento.Observacao.ReplaceSaveObservacaoProthues();
                        var codiviergencia = _prothuesService.ObterCodigoDivergenciaPorCodigo(Convert.ToString(marcacao.Lancamento.CodDivergencia));
                        if (marcacao.Lancamento.CodDivergencia != null && marcacao.Lancamento.CodDivergencia != 0) {
                         codiv.ValidaCodigoDivergencia(codiviergencia);
                        codiv.ValidaCodigoDivergenciaConstante(codiviergencia.Constant, marcacao.Lancamento.CodDivergencia);
                        }
                        lancamento = marcacao.Lancamento;
                        lancamento.ValidaHorasLancamentoOutraMarcacao(_lancamentoerviceRepository.ObterLancamento(marcacao.DataDia.ToDateProtheus(), User.GetDados("Matricula")));
                        marcacao.Lancamento.Codigo = aberturaMarcacao.AbeturaExiste(_marcacao.ObterListMarcacaoPorMatUser(User.GetDados("Matricula")), marcacao.DataDia.ToDia(), marcacao.DataDia.ToAno());
                        marcacao.Lancamento.codEmpredimento = marcacao.Lancamento.EmpreendimentoIds[0].Substring(0, marcacao.Lancamento.EmpreendimentoIds[0].IndexOf('-'));
                        marcacao.Lancamento.Fase = marcacao.Lancamento.EmpreendimentoIds[0].Substring(marcacao.Lancamento.EmpreendimentoIds[0].IndexOf('-') + 1);
                        _lancamentoerviceRepository.SalvarLancamento(_mapper.Map<Lancamento>(marcacao.Lancamento), User.GetDados("Filial"), marcacao.DataDia.ToDateProtheus());
                    }
                    return Json(new { sucesso = "Lançamento cadastrado com sucesso!" });
                }

                return Json(new
                {
                    msg = string.Join("\n", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage)),
                    erro = true
                });
            }
            catch (Exception e)
            {
                return Json(new { msg = e.Message, erro = true });
            }

        }

        public ActionResult Edit(string id)
        {
            try
            {

                ViewModelMacacao marcacao = new ViewModelMacacao();


                var infoUser = new ViewModelMacacao();
                var user = new Usuario();
                marcacao.MatUsuario = User.GetDados("Matricula");
                marcacao.Coordenacao = User.GetDados("Coordenacao");
                user = _prothuesService.ObterUsuarioNome(User.GetDados("Matricula"));
                marcacao.NomeUsuario = user.Nome;
                var objectmarcacao =  _marcacaoServiceRepository.ObterMarcacao(id);
                var jornada =  _jornadaTrbServiceRepository.ObterJornadaPorCodigo(objectmarcacao.codigojornada);
                marcacao.jornadaMin = jornada.JornadaMin;
                marcacao.jornadaMax = jornada.JornadaMax;
                return View(marcacao);

            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View(marcacao);
            }

        }

        public ActionResult EditFechamento(string id, string codmarcacao)
        {
            try
            {

                ViewModelMacacao marcacao = new ViewModelMacacao();


                var infoUser = new ViewModelMacacao();
                var user = new Usuario();
                marcacao.MatUsuario = User.GetDados("Matricula");
                marcacao.Coordenacao = User.GetDados("Coordenacao");
                user = _prothuesService.ObterUsuarioNome(User.GetDados("Matricula"));
                marcacao.NomeUsuario = user.Nome;
                marcacao.DataDialancamento = Convert.ToDateTime(id.ToDateProtheusReverseformate());
                return View(marcacao);

            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View("Edit",marcacao);
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ViewModelMacacao marcacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ViewModelLancamento lancamentoAliplication = new ViewModelLancamento();
                    Marcacao aberturaMarcacao = new Marcacao();
                    JornadaTrabalho jornada = new JornadaTrabalho();
                    CodDivergenciaViewModel codiv = new CodDivergenciaViewModel();

                    if (marcacao.Lancamento != null)
                    {
                        marcacao.Lancamento.ValidaHoraLancamento();
                        marcacao.Lancamento.Observacao = marcacao.Lancamento.Observacao.ReplaceSaveObservacaoProthues();
                        var codiviergencia = _prothuesService.ObterCodigoDivergenciaPorCodigo(Convert.ToString(marcacao.Lancamento.CodDivergencia));
                        if (marcacao.Lancamento.CodDivergencia != null && marcacao.Lancamento.CodDivergencia !=0)
                        {
                            codiv.ValidaCodigoDivergencia(codiviergencia);
                            codiv.ValidaCodigoDivergenciaConstante(codiviergencia.Constant, marcacao.Lancamento.CodDivergencia);
                        }
                        lancamentoAliplication = marcacao.Lancamento;
                        if (marcacao.DataDialancamento != null){ 
                        marcacao.DataDia = marcacao.DataDialancamento?.ToString("yyyy-MM-dd");
                        }
                        lancamentoAliplication.ValidaHorasLancamentoOutraMarcacao(_lancamentoerviceRepository.ObterLancamento(marcacao.DataDia.ToDateProtheus(), User.GetDados("Matricula")));
                        marcacao.Lancamento.codEmpredimento = marcacao.Lancamento.EmpreendimentoIds[0].Substring(0, marcacao.Lancamento.EmpreendimentoIds[0].IndexOf('-'));
                        marcacao.Lancamento.Fase = marcacao.Lancamento.EmpreendimentoIds[0].Substring(marcacao.Lancamento.EmpreendimentoIds[0].IndexOf('-')+1);
                        _lancamentoerviceRepository.AtualizarLancamento(_mapper.Map<Lancamento>(marcacao.Lancamento));
                    }


                    return Json(new { sucesso = "Lançamento atualizado com sucesso!" });
                }

                return Json(new
                {
                    msg = string.Join("; ", ModelState.Values
                                       .SelectMany(x => x.Errors)
                                       .Select(x => x.ErrorMessage)),
                    erro = true
                });
            }
            catch (Exception e)
            {
                return Json(new { msg = e.Message, erro = true });
            }

        }



        [HttpPost]
        public IActionResult ListApontamento(ViewModelLancamento viewModelLancamento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                }
                return View();
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }

        [HttpGet]
        public ActionResult ListApontamento(string matricula, string filial, string data)
        {
            try
            {
                if (data != null)
                {
                    config = new Configuracao();
                    marcacao = new Marcacao();

                    var ano = data.Substring(0, 4);
                    var dia = data.Substring(5, 2);
                    var mes = data.Substring(8, 2);
                    data = ano+dia+mes;
                    matricula = User.GetDados("Matricula");
                    filial = User.GetDados("Filial");
                    var JornadaDiaria = _jornadaTrbNegocio.ObterListaJornadaPorData(data);
                   


                }
                return Json(_prothuesService.ObterBatidasDePonto(matricula, filial, data));

            }
            catch (Exception e)
            {
                return Json(new { msg = e.Message, erro = true });
            }
        }


        [HttpGet]
        public ActionResult ObterJornadaDiariaPorData(string data)
        {
            try
            {

                var ano = data.Substring(0, 4);
                var mes = data.Substring(5, 2);
                var dia = data.Substring(8, 2);
                data = ano + mes + dia;
                return Json(_jornadaTrbNegocio.ObterListaJornadaPorData(data));
            }
            catch (Exception e)
            {
                return Json(new { msg = e.Message, erro = true });
            }
        }
        [HttpGet]
        public ActionResult ImportarApontamento(string matricula, string filial, string data)
        {
            try
            {
                
                    config = new Configuracao();
                    marcacao = new Marcacao();

                    var ano = data.Substring(0, 4);
                    var mes = data.Substring(5, 2);
                    var dia = data.Substring(8, 2);
                    data = ano + mes + dia;
                    matricula = User.GetDados("Matricula");
                    filial = User.GetDados("Filial");

                    var listApontamento = _prothuesService.ObterBatidasDePonto(matricula, filial, data);
                    var listMarcacoes = _lancamentoerviceRepository.ObterLancamento(data, User.GetDados("Matricula")).OrderBy(c => c.HoraInicio).ToList();
                    for(int i=0; i < listApontamento.Count; i++)
                    {
                        foreach(Lancamento lancamento in listMarcacoes)
                        {
                            if (listApontamento[i].horaFim == lancamento.HoraInicio)
                            {
                              
                                listApontamento.Remove(listApontamento[i+1]);
                                listApontamento.Remove(listApontamento[i]);
                             }
                        }
                    }

                return Json(listApontamento);

            }
            catch (Exception e)
            {
                return Json(new { msg = e.Message, erro = true });
            }
        }

        [HttpGet]
        public ActionResult GetMarcacoes(string data)
        {
            if (data != null)
            {
                var ano = data.Substring(0, 4);
                var mes = data.Substring(5, 2);
                var dia = data.Substring(8, 2);
                data = ano+mes+dia;

            }


            return Json(_lancamentoerviceRepository.ObterLancamento(data, User.GetDados("Matricula")).OrderBy(c => c.HoraInicio).ToList());
        }

        [HttpGet]
        public ActionResult GetMarcacoesProthues(string data, string matricula)
        {
            return Json(_lancamentoerviceRepository.ObterLancamento(data, matricula).OrderBy(c => c.HoraInicio).ToList());
        }

        public JsonResult Excluir(string codigo)
        {

            try
            {
                _marcacaoServiceRepository.DeleteMarcacao(codigo);
                return Json(new { sucesso = "Marcação excluída com sucesso!" });
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


        public ActionResult Details(string id)
        {

            try
            {

                var list = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());
                ViewModelMacacao marcacao = new ViewModelMacacao();
                marcacao = _mapper.Map<ViewModelMacacao>(_marcacaoServiceRepository.ObterMarcacao(id));

                var infoUser = new ViewModelMacacao();
                var user = new Usuario();
                marcacao.MatUsuario = User.GetDados("Matricula");
                marcacao.Coordenacao = User.GetDados("Coordenacao");
                user = _prothuesService.ObterUsuarioNome(User.GetDados("Matricula"));
                marcacao.NomeUsuario = user.Nome;

                var mes = marcacao.AnoMes.ToString().Substring(4, 2);
                var ano = marcacao.AnoMes.ToString().Substring(0, 4);
                string month = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(Convert.ToInt32(mes));
                var objectmarcacao = _marcacaoServiceRepository.ObterMarcacao(id);
                var jornada = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(objectmarcacao.codigojornada);
                marcacao.jornadDiaria = jornada.JornadaDiaria;
                marcacao.AnoMesDescricao = char.ToUpper(month[0]) + month.Substring(1) + "/" + ano;
                marcacao.Lancamentolist = _mapper.Map<List<ViewModelLancamento>>(list);
                return View(marcacao);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

    }

        public ActionResult DetailsVisaoGerencia(string id)
        {

            try
            {     Marcacao maracaouser = new Marcacao();

                maracaouser = _marcacao.ObterMarcacao(id);
                var list = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, maracaouser.MatUsuario).Distinct(new LancamentoComparer());
                ViewModelMacacao marcacao = new ViewModelMacacao();
                marcacao = _mapper.Map<ViewModelMacacao>(_marcacaoServiceRepository.ObterMarcacao(id));

                var infoUser = new ViewModelMacacao();
                var user = new Usuario();
                user = _prothuesService.ObterUsuarioNome(maracaouser.MatUsuario);
                marcacao.MatUsuario = marcacao.MatUsuario;
                marcacao.Coordenacao = User.GetDados("Coordenacao");
                marcacao.NomeUsuario = user.Nome;


                var mes = marcacao.AnoMes.ToString().Substring(4, 2);
                var ano = marcacao.AnoMes.ToString().Substring(0, 4);
                string month = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(Convert.ToInt32(mes));

                marcacao.AnoMesDescricao = char.ToUpper(month[0]) + month.Substring(1) + "/" + ano;
                marcacao.Lancamentolist = _mapper.Map<List<ViewModelLancamento>>(list);
                return View("Details",marcacao);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }


        public ActionResult PesquisarMarcacao()
         {

            try
            {
                return View();
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }


        [HttpGet]
        public ActionResult ObterColaborador(string descricao)
        {
            return Json(_prothuesService.ObterListColaboradorPorCentroDeCusto(descricao, User.GetDados("Centro de Custo")));
        }

        [HttpGet]
        public ActionResult GetMarcacaoColaborador(string matricula)
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
            return Json(list);
        }

        private string ObterPrimeiroDia(Configuracao configuracao, ViewModelMacacao marcacao)
        {
            DateTime primeiroDiaDoMes = new DateTime(Convert.ToDateTime(marcacao.DataDia).Year, Convert.ToDateTime(marcacao.DataDia).Month, configuracao.DiaInicio);
            return primeiroDiaDoMes.ToString("dd/MM/yyyy").ToDateProtheusConvert();
        }

        private string ObterDiaFim(Configuracao configuracao, ViewModelMacacao marcacao)
        {
            DateTime ultimoDiaDoMes = new DateTime(Convert.ToDateTime(marcacao.DataDia).Year, Convert.ToDateTime(marcacao.DataDia).Month, DateTime.DaysInMonth(Convert.ToDateTime(marcacao.DataDia).Year, Convert.ToDateTime(marcacao.DataDia).Month));
            return ultimoDiaDoMes.ToString("dd/MM/yyyy").ToDateProtheusConvert();
        }

        
    }


}