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
    [Authorize]
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
            TempData["CreateSucesso"] = null;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarHora(ViewModelCadastroHora viewModelCadastroHora)
        {
            TempData["CreateSucesso"] = null;
            try
            {

                if (ModelState.IsValid)
                {
                    JornadaTrabalho jornadaTrabalhoNeogocio = new JornadaTrabalho();
                    jornadaTrabalhoNeogocio = _mapper.Map<JornadaTrabalho>(viewModelCadastroHora);
                    jornadaTrabalhoNeogocio.ValidarJornadaTrabalhoSobreposta(_jornadaTrbServiceRepository.ObterListJornada());
                    viewModelCadastroHora.ValidaHorario();
                    viewModelCadastroHora.ValidaIntervalo();
                    viewModelCadastroHora.ValidaJornadaDiaria();
                    viewModelCadastroHora.ValidaData();
                    viewModelCadastroHora.ValidaJornadaMax();

                    var JornadaTrb = _mapper.Map<JornadaTrabalho>(viewModelCadastroHora);
                    _jornadaTrbServiceRepository.SalvarJornada(JornadaTrb);
                    TempData["JornadaCadastrada"] = true;
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
                if (ModelState.IsValid)
                {
                    viewModelCadastroHora.ValidaHorario();
                    viewModelCadastroHora.ValidaIntervalo();
                    viewModelCadastroHora.ValidaJornadaDiaria();
                    viewModelCadastroHora.ValidaData();
                    viewModelCadastroHora.ValidaJornadaMax();
                    var JornadaTrb = _mapper.Map<JornadaTrabalho>(viewModelCadastroHora);
                    _jornadaTrbServiceRepository.AtualizarJornada(JornadaTrb);
                    TempData["CreateSucesso"] = true;
                }
                return View(viewModelCadastroHora);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View(viewModelCadastroHora);
            }
        }

        public ActionResult Details(string id)
        {
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

       
        public ActionResult Delete(int id)
        {
            try
            {
                TempData["exclusao"] = null;
                var viewMJrtb = _mapper.Map<ViewModelCadastroHora>(_jornadaTrbServiceRepository.ObterJornadaPorCodigo(Convert.ToString(id)));
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
        public ActionResult Delete(string id)
        {
            try
            {
                TempData["exclusao"] = null;
                _jornadaTrbServiceRepository.DeleteJornada(id);
                TempData["exclusao"] = true;
                return RedirectToAction("Index", "JornadaTrabalho");
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return RedirectToAction("Index", "JornadaTrabalho");
            }
        }

    }
}