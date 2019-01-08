using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    [AllowAnonymous]
    public class MarcacaoController : Controller
    {
        public IActionResult Index()
        {
            List<ViewModelCadastroHora> listCadHora = new List<ViewModelCadastroHora>();
            var cadhoras = new ViewModelCadastroHora();
            cadhoras = null;
            listCadHora.Add(cadhoras);
            return View(listCadHora);
        }

        public IActionResult Lancamento()
        {

            return View();
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
    }
}