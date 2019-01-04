using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    [AllowAnonymous]
    public class JornadaTrabalhoController : Controller
    {
        private readonly IJornadaTrabalho _jornadaTrbServiceRepository;
        private readonly IMapper _mapper;

        public JornadaTrabalhoController(IJornadaTrabalho jornadaTrb, IMapper mapper)
        {
            _jornadaTrbServiceRepository = jornadaTrb;
            _mapper = mapper;
         
        }
        public IActionResult Index()
        {
            try
            {
             
                var list = _mapper.Map<List<JornadaTrabalho>, List<ViewModelCadastroHora>>(_jornadaTrbServiceRepository.ObterListJornada());
                return View(list);

            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
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
                    

                    var JornadaTrb = _mapper.Map<JornadaTrabalho>(viewModelCadastroHora);
                    _jornadaTrbServiceRepository.SalvarJornada(JornadaTrb);
                    TempData["CreateSucesso"] = true;
                    return RedirectToAction("Index", "JornadaTrabalho");
                }
                return View(viewModelCadastroHora);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }

        public ActionResult Edit(string id)
        {
            TempData["CreateSucesso"] = null;
            try
            {
                var viewMJrtb = _mapper.Map<ViewModelCadastroHora>(_jornadaTrbServiceRepository.ObterJornadaPorCodigo(id));
                return View(viewMJrtb);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ViewModelCadastroHora viewModelCadastroHora)
        {
            TempData["CreateSucesso"] = null;
            try
            {
                viewModelCadastroHora.ValidaHorario();
                viewModelCadastroHora.ValidaIntervalo();
                viewModelCadastroHora.ValidaJornadaDiaria();
                 viewModelCadastroHora.ValidaData();
                var JornadaTrb = _mapper.Map<JornadaTrabalho>(viewModelCadastroHora);
                _jornadaTrbServiceRepository.AtualizarJornada(JornadaTrb);
                TempData["CreateSucesso"] = true;
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