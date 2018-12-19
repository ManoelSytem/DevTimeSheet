using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    [AllowAnonymous]
    public class JornadaTrabalhoController : Controller
    {
        public IActionResult Index()
        {
            List<ViewModelCadastroHora> listCadHora = new List<ViewModelCadastroHora>();
            var cadhoras = new ViewModelCadastroHora();
            cadhoras = null;
            listCadHora.Add(cadhoras);
            return View(listCadHora);
        }


        public IActionResult CadastrarHora()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarHora(ViewModelCadastroHora viewModelCadastroHora)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    viewModelCadastroHora.ValidaHorario();
                    viewModelCadastroHora.ValidaIntervalo();
                    viewModelCadastroHora.ValidaJornadaDiaria();
                    viewModelCadastroHora.ValidaData();
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