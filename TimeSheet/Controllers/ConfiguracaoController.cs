using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    [Authorize]
    public class ConfiguracaoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IConfiguracao  _config;
        private readonly IProtheus _prothuesService;
        private CodDivergenciaViewModel codiv;

        public ConfiguracaoController(IConfiguracao config, IMapper mapper, IProtheus prothuesService)
        {
            _config = config;
            _mapper = mapper;
            _prothuesService = prothuesService;
        }

        // GET: Configuracao
        public ActionResult Index()
        {
            try
            {

            List<ViewModelConfiguracao> listaConfig = new List<ViewModelConfiguracao>();
            var viewModelConfiguracao = _mapper.Map<ViewModelConfiguracao>(_config.ObterConfiguracao());
            listaConfig.Add(viewModelConfiguracao);
            return View(listaConfig);

            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }

        // GET: Configuracao/Details/5
        public ActionResult Details(int id)
        {
            try
            {

                List<ViewModelConfiguracao> listaConfig = new List<ViewModelConfiguracao>();
                var viewModelConfiguracao = _mapper.Map<ViewModelConfiguracao>(_config.ObterConfiguracao());
                foreach (string value in _config.ObterTextoEmail())
                {
                    viewModelConfiguracao.TextoEmail += value;
                }
                listaConfig.Add(viewModelConfiguracao);
                return View(viewModelConfiguracao);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }

        // GET: Configuracao/Create
        public ActionResult Create()
        {
            TempData["CreateSucesso"] = null;
            return View();
        }

        // POST: Configuracao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ViewModelConfiguracao viewConfiguracao)
        {
            TempData["CreateSucesso"] = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var viewModelConfiguracao = _mapper.Map<ViewModelConfiguracao>(_config.ObterConfiguracao());
                    if(viewModelConfiguracao == null) { 

                    viewConfiguracao.ValidarDiaInicioFim();
                    viewConfiguracao.ValidarDatalimiteEntrePeriodo();
                    viewConfiguracao.ValidarFrequenciaSelecionada();
                    var codiviergencia = _mapper.Map<CodDivergenciaViewModel>(_prothuesService.ObterCodigoDivergenciaPorCodigo(viewConfiguracao.CodDivergencia));
                    codiv = new CodDivergenciaViewModel();
                    codiv.ValidaCodigoDivergencia(codiviergencia);
                    codiv.codigo = codiviergencia.codigo;
                    var configuracao = _mapper.Map<Configuracao>(viewConfiguracao);
                    _config.SalvarConfiguracao(configuracao, User.GetDados("Filial")?.Split(',').First(), User.GetDados("Matricula")?.Split(',').First());
                    _config.SalvarTextoEmail(viewConfiguracao.TextoEmail);
                    TempData["Configuracao"] = true;
                    }
                    else
                    {
                        TempData["Createfalse"] = "Já existe configuração cadastrada!";
                    }
                    return RedirectToAction("Index", "Configuracao");
                }
                return View(viewConfiguracao);
            }
            catch(Exception e)
            {
                if (codiv.ValidaConfiguracaoExiste(e.Message) != null)
                {
                    TempData["Createfalse"] = codiv.ValidaConfiguracaoExiste(e.Message);
                }else
                {
                    TempData["Createfalse"] = e.Message;
                }
                return View(viewConfiguracao);
            }
        }

        // GET: Configuracao/Edit/5
        public ActionResult Edit(int id)
        {
            TempData["CreateSucesso"] = null;
            try
            {
                List<ViewModelConfiguracao> listaConfig = new List<ViewModelConfiguracao>();
                var viewModelConfiguracao = _mapper.Map<ViewModelConfiguracao>(_config.ObterConfiguracao());
                 listaConfig.Add(viewModelConfiguracao);
                foreach (string value in _config.ObterTextoEmail())
                {
                    viewModelConfiguracao.TextoEmail += value;
                }
                return View(viewModelConfiguracao);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }


        // POST: Configuracao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ViewModelConfiguracao viewConfiguracao)
        {
            TempData["CreateSucesso"] = null;
            try
            {
                if (ModelState.IsValid)
                {
                    viewConfiguracao.ValidarDiaInicioFim();
                    viewConfiguracao.ValidarDatalimiteEntrePeriodo();
                    viewConfiguracao.ValidarFrequenciaSelecionada();
               
                    viewConfiguracao.FilialProtheus = User.GetDados("Filial")?.Split(',').First();
                    viewConfiguracao.MatriculaUsuario = User.GetDados("Matricula")?.Split(',').First();
                    var configuracao = _mapper.Map<Configuracao>(viewConfiguracao);
                    var codiviergencia = _mapper.Map<CodDivergenciaViewModel>(_prothuesService.ObterCodigoDivergenciaPorCodigo(viewConfiguracao.CodDivergencia));
                    codiv = new CodDivergenciaViewModel();
                    codiv.ValidaCodigoDivergencia(codiviergencia);
                    _config.AtualizarConfiguracao(configuracao);
                    _config.SalvarTextoEmail(viewConfiguracao.TextoEmail);
                    TempData["CreateSucesso"] = true;
                    return View(viewConfiguracao);
                }
                return View(viewConfiguracao);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }

        // GET: Configuracao/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                TempData["CreateSucesso"] = null;
                List<ViewModelConfiguracao> listaConfig = new List<ViewModelConfiguracao>();
                var viewModelConfiguracao = _mapper.Map<ViewModelConfiguracao>(_config.ObterConfiguracao());
                foreach (string value in _config.ObterTextoEmail())
                {
                    viewModelConfiguracao.TextoEmail += value;
                }
                listaConfig.Add(viewModelConfiguracao);
                return View(viewModelConfiguracao);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }

        // POST: Configuracao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ViewModelConfiguracao viewConfiguracao)
        {
            try
            {
                _config.DeleteConfiguracao(Convert.ToString(viewConfiguracao.Codigo));
                TempData["CreateSucesso"] =  true;
                return RedirectToAction("Index","Configuracao");
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }

        
        public JsonResult GetSearchValue(string search)
        {
            List<CodDivergenciaViewModel> allsearch = _prothuesService.ObterListCodDivergenciaPordescricao(search.ToUpper()).ToList().Select(x => new CodDivergenciaViewModel
            {
                Descricao = x.Descricao,
                codigo = x.codigo
               
            }).ToList();

            return Json(allsearch);
        }
    }
}