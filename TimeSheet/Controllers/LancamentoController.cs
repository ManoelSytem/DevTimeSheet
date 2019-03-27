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
    [Authorize]
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
        [HttpGet]
        public IActionResult Index(string horainicio, string horafim)
        {
            try
            {
              ViewModelLancamento lancamento = new ViewModelLancamento();
                ViewModelMacacao marcacao = new ViewModelMacacao();
                lancamento.HoraInicio = TimeSpan.Parse(horainicio);
                lancamento.HoraFim = TimeSpan.Parse(horafim);
                marcacao.Lancamento = lancamento;
                return View(marcacao);
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
        public ActionResult Edit(string data, string seq)
        {
            try
            {
                ViewModelMacacao viewMarcacao = new ViewModelMacacao();
                var lancamento = _mapper.Map<ViewModelLancamento>(_lancamentoServiceRepository.ObterLancamentoEdit(data, User.GetDados("Matricula"), seq));
                viewMarcacao.Lancamento = lancamento;
                ViewBag.descricaoEmprendimento = lancamento.DescricaoEmp;
                ViewBag.codigoEmpreendimento = lancamento.codEmpredimento;
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
                codigo = x.codigo,
                Constant = x.Constant
                

            }).ToList();

            return Json(allsearch);
        }

        public JsonResult GetEmpreendimentos(string nome)
        {
            return Json(_prothuesService.ObterListEmpreendimentos(nome.Trim()));
        }

        public JsonResult Excluir(string seq)
        {

            try
            {
                 _lancamentoServiceRepository.DeleteLancamento(seq);
                return Json(new { sucesso = "Lançamento excluído com sucesso!" });
            }
            catch (Exception e)
            {
                return Json(new
                {
                    msg = string.Join("; ", ModelState.Values
                                      .SelectMany(x => x.Errors)
                                      .Select(x => x.ErrorMessage)),
                    erro = true
                });
            }
           
        }


        public ActionResult Details(string data, string seq)
        {
            try
            {
                
                var lancamento = _mapper.Map<ViewModelLancamento>(_lancamentoServiceRepository.ObterLancamentoEdit(data, User.GetDados("Matricula"), seq));
                ViewBag.descricaoEmprendimento = lancamento.DescricaoEmp;
                ViewBag.codigoEmpreendimento = lancamento.codEmpredimento;
                return View(lancamento);

            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }
    }
}