using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.Models;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    public class LancamentoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProtheus _prothuesService;
        private readonly ILancamento _lancamentoServiceRepository;
        public LancamentoController(IConfiguracao config, IMapper mapper, IProtheus prothuesService , ILancamento lancamentoServiceRepository)
        {
            _mapper = mapper;
            _prothuesService = prothuesService;
            _lancamentoServiceRepository = lancamentoServiceRepository;
        }

        public IActionResult Index()
        {
            try
            {
                return View();
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

        [HttpGet]
        public ActionResult Edit(string data, string codlancamento)
        {
            try
            {
                var ano = data.Substring(0, 4);
                var mes = data.Substring(5, 2);
                var dia = data.Substring(8, 2);
                data = ano + mes + dia;
                ViewModelMacacao viewMarcacao = new ViewModelMacacao();
                var lancamento = _mapper.Map<ViewModelLancamento>(_lancamentoServiceRepository.ObterLancamentoEdit(data, User.GetDados("Matricula"), codlancamento));
                viewMarcacao.Lancamento = lancamento;
                return View(viewMarcacao);

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

        public JsonResult GetEmpreendimentos(string nome)
        {
            return Json(_prothuesService.ObterListEmpreendimentos(nome));
        }

    }
}