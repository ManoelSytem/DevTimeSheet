using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Domain.Util;
using TimeSheet.Models;

namespace TimeSheet.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var perfis = User.GetPerfil();
               
                if (User.GetDados("AREA").ToString() == Constantes.COORDENADOR)
                {
                    TempData["Perfil"] = Constantes.COORDENADOR;
                }
                if (User.GetDados("AREA").ToString() == Constantes.ENGENHEIRO)
                {
                    TempData["Perfil"] = Constantes.ENGENHEIRO;
                }
                if (User.GetDados("AREA").ToString() == Constantes.TECNICO)
                {
                    TempData["Perfil"] = Constantes.TECNICO;
                }

            }
            catch (Exception ex)
            {
               
            }
          
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
