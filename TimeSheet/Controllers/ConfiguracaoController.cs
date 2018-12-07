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
            List<ViewModelConfiguracao> listaConfig = new List<ViewModelConfiguracao>();
            ViewModelConfiguracao cfig1 = new ViewModelConfiguracao(1,2,2018);
            listaConfig.Add(cfig1); 
            return View(listaConfig);
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
                    var configuracao = _mapper.Map<Configuracao>(viewConfiguracao);
                    _config.SalvarConfiguracao(configuracao);
                }
                return View(viewConfiguracao);
            }
            catch
            {
                return View();
            }
        }

        // GET: Configuracao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Configuracao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
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