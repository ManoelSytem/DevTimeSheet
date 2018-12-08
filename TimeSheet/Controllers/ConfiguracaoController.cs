using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    public class ConfiguracaoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IConfiguracao  _config;

        public ConfiguracaoController(IConfiguracao config, IMapper mapper)
        {
            _config = config;
            _mapper = mapper;
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
                return View();
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
            return View();
        }

        // POST: Configuracao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}