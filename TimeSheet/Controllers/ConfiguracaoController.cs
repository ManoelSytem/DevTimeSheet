using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    public class ConfiguracaoController : Controller
    {
        // GET: Configuracao
        public ActionResult Index()
        {
            List<ViewModelConfiguracao> listaConfig = new List<ViewModelConfiguracao>();
            ViewModelConfiguracao cfig1 = new ViewModelConfiguracao();
            ViewModelConfiguracao cfig2 = new ViewModelConfiguracao();
            ViewModelConfiguracao cfig3 = new ViewModelConfiguracao();

            listaConfig.Add(cfig1); listaConfig.Add(cfig2); listaConfig.Add(cfig3);
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
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