using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Models;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    public class LancamentoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProtheus _prothuesService;
       
        public LancamentoController(IConfiguracao config, IMapper mapper, IProtheus prothuesService)
        {
            _mapper = mapper;
            _prothuesService = prothuesService;
        }

        public IActionResult Index()
        {
            try
            {
                var lancamento = new ViewModelLancamento();
                lancamento.Empreendimentos = null;

                ViewBag.Empreendimentos = lancamento.Empreendimentos.Select(x => new SelectListItem($"{x.CodigoProtheus} - {x.Nome}", x.CodigoProtheus.ToString(), false))?.ToList() ?? new List<SelectListItem>();
                return View(lancamento);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ViewModelLancamento viewModelLancamento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["CreateSucesso"] = true;
                    return View(viewModelLancamento);
                }
                return View(viewModelLancamento);
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

        public JsonResult GetEmpreendimentos(string search)
        {
            return Json(_prothuesService.ObterListEmpreendimentos(search));
        }

    }
}