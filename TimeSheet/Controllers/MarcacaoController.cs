using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Models;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    [AllowAnonymous]
    public class MarcacaoController : Controller
    {
        public IActionResult Index()
        {
            var nova = new ViewModelMacacao();
            return View(nova );
        }

        public IActionResult Lancamento()
        {
            var nova = new ViewModelMacacao();
            return View(nova);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Lancamento(ViewModelLancamento viewModelLancamento)
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
        public JsonResult ListApontamento(string matricula)
        {
            List<Apontamento> apontamento = new List<Apontamento>();
            var ap = new Apontamento();
            apontamento.Add(ap);
            return Json(apontamento);
        }
    }
}