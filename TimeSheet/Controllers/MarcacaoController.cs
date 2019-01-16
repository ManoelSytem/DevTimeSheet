using System;
using System.Collections.Generic;
using System.Globalization;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.Models;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    [AllowAnonymous]
    public class MarcacaoController : Controller
    {
        private readonly IProtheus _prothuesService;
        private readonly IConfiguracao _configuracao;
        private readonly IMarcacao _marcacao;
        private readonly ILancamento _lancamentoerviceRepository;
        private readonly IMarcacao _marcacaoServiceRepository;
        private readonly IMapper _mapper;
        Configuracao config;
        Marcacao marcacao;
        public MarcacaoController(IProtheus prothuesService, IMarcacao marcacaoServiceRepository, IMapper mapper, IConfiguracao configuracao, IMarcacao marcacao, ILancamento lancamento)
        {
            _prothuesService = prothuesService;
            _marcacaoServiceRepository = marcacaoServiceRepository;
            _mapper = mapper;
            _configuracao = configuracao;
            _marcacao = marcacao;
            _lancamentoerviceRepository = lancamento;

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
                Marcacao maca = new Marcacao();
                string codigoAbertura = maca.AbeturaExiste(_marcacao.ObterListMarcacaoPorMatUser(User.GetDados("Matricula")),  marcacao.DataDia.ToDia(), marcacao.DataDia.ToAno());

                if (codigoAbertura == "0")
                {
                    Random randNum = new Random();
                    marcacao.AnoMes = marcacao.DataDia.ToShortDateProtheus();
                    marcacao.MatUsuario = User.GetDados("Matricula");
                    marcacao.Filial = User.GetDados("Filial");
                    marcacao.Status = Constantes.ABERTO;
                    marcacao.CodLancamento = Convert.ToString(randNum.Next(10, 500));
                    _marcacao.SalvarMarcacao(_mapper.Map<Marcacao>(marcacao));

                }

                if (marcacao.Lancamento != null)
                {
                    marcacao.Lancamento.Codigo = codigoAbertura;
                    marcacao.Lancamento.codEmpredimento = marcacao.Lancamento.EmpreendimentoIds[0];
                    _lancamentoerviceRepository.SalvarLancamento(_mapper.Map<Lancamento>(marcacao.Lancamento), User.GetDados("Filial"), marcacao.DataDia.ToDateProtheus());
                }
                
                TempData["CreateSucesso"] = true;
                return View(marcacao);

            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View(marcacao);
            }

        }

        public ActionResult Edit(string codigo)
        {
            try
            {
                
                var list = _mapper.Map<List<Marcacao>, List<ViewModelMacacao>>(_marcacaoServiceRepository.ObterListMarcacaoPorMatUser(User.GetDados("Matricula")));

                return View(list);

            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View(marcacao);
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
                config = new Configuracao();
                marcacao = new Marcacao();

                var ano = data.Substring(0, 4);
                var mes = data.Substring(5, 2);
                var dia = data.Substring(8, 2);
                data = ano + mes + dia;
                matricula = User.GetDados("Matricula");
                filial = User.GetDados("Filial");

                config = _configuracao.ObterConfiguracao();
                config.ValidaConfiguracaoMarcacao(dia + "/" + mes + "/" + ano, dia);

                marcacao.ValidarAbeturaMarcacaoExiste(_marcacao.ObterListMarcacaoPorMatUser(User.GetDados("Matricula")), ano, mes);
                
                return Json(_prothuesService.ObterBatidasDePonto(matricula, filial, data));

            }
            catch (Exception e)
            {
                return Json(new { msg = e.Message, erro = true });
            }
        }

        [HttpGet]
        public ActionResult GetMarcacoes(string data)
        {
            var ano = data.Substring(0, 4);
            var mes = data.Substring(5, 2);
            var dia = data.Substring(8, 2);
            data = ano + mes + dia;
            return Json(_lancamentoerviceRepository.ObterLancamento(data, User.GetDados("Matricula")));
        }

     }
}