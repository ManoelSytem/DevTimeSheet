using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty.Interface;
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
            return View();
        }

        // GET: Configuracao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Configuracao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ViewModelConfiguracao viewConfiguracao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    viewConfiguracao.ValidarDiaInicioFim();
                    viewConfiguracao.ValidarDatalimiteEntrePeriodo();
                    var codiviergencia = _mapper.Map<CodDivergenciaViewModel>(_prothuesService.ObterCodigoDivergenciaPorContigo(viewConfiguracao.CodDivergencia));
                    codiv.ValidaCodigoDivergencia(codiviergencia.codigo);
                    var configuracao = _mapper.Map<Configuracao>(viewConfiguracao);
                    _config.SalvarConfiguracao(configuracao);
                    TempData["CreateSucesso"] = true;
                    return View();
                }
                return View(viewConfiguracao);
            }
            catch(Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View(viewConfiguracao);
            }
        }

        // GET: Configuracao/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                List<ViewModelConfiguracao> listaConfig = new List<ViewModelConfiguracao>();
                var viewModelConfiguracao = _mapper.Map<ViewModelConfiguracao>(_config.ObterConfiguracao());
                 listaConfig.Add(viewModelConfiguracao);
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
            try
            {
                if (ModelState.IsValid)
                {
                    
                    var configuracao = _mapper.Map<Configuracao>(viewConfiguracao);
                    var codiviergencia = _mapper.Map<CodDivergenciaViewModel>(_prothuesService.ObterCodigoDivergenciaPorContigo(viewConfiguracao.CodDivergencia));
                    codiv = new CodDivergenciaViewModel();
                    codiv.ValidaCodigoDivergencia(codiviergencia);
                    _config.AtualizarConfiguracao(configuracao);
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
                List<ViewModelConfiguracao> listaConfig = new List<ViewModelConfiguracao>();
                var viewModelConfiguracao = _mapper.Map<ViewModelConfiguracao>(_config.ObterConfiguracao());
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
                var configuracao = _mapper.Map<Configuracao>(viewConfiguracao);
                _config.DeleteConfiguracao(configuracao);
                TempData["CreateSucesso"] = true;
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