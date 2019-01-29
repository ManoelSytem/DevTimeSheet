﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    public class FechamentoController : Controller
    {
        private readonly IProtheus _prothuesService;
        private readonly IConfiguracao _configuracao;
        private readonly IMarcacao _marcacao;
        private readonly ILancamento _lancamentoerviceRepository;
        private readonly IMarcacao _marcacaoServiceRepository;
        private readonly IMapper _mapper;
        private readonly IJornadaTrabalho _jornadaTrbServiceRepository;
        private readonly IFechamento _fechamentoServiceRepository;

        public FechamentoController(IFechamento fechamentoServiceRepository, IProtheus prothuesService, IMarcacao marcacaoServiceRepository, IMapper mapper, IConfiguracao configuracao, IMarcacao marcacao, ILancamento lancamento, IJornadaTrabalho jornada)
        {
            _prothuesService = prothuesService;
            _marcacaoServiceRepository = marcacaoServiceRepository;
            _mapper = mapper;
            _configuracao = configuracao;
            _marcacao = marcacao;
            _lancamentoerviceRepository = lancamento;
            _jornadaTrbServiceRepository = jornada;
            _fechamentoServiceRepository = fechamentoServiceRepository;

        }

        public IActionResult Index()
        {
            try
            {
                var list = _mapper.Map<List<Marcacao>, List<ViewModelMacacao>>(_marcacaoServiceRepository.ObterListMarcacaoPorMatUser(User.GetDados("Matricula")));
                if (list.Count > 0)
                {
                    foreach (var lista in list)
                    {
                        var mes = lista.AnoMes.ToString().Substring(4, 2);
                        var ano = lista.AnoMes.ToString().Substring(0, 4);
                        string month = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(Convert.ToInt32(mes));
                        lista.AnoMesDescricao = char.ToUpper(month[0]) + month.Substring(1) + "/" + ano;
                    }

                }
                return View(list);
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }

        public IActionResult ValidarFechamento(string id)
        {
            try
            {

                Marcacao marcacao = new Marcacao();
                Fechamento fechamento = new Fechamento();

                var ResultFechamento = ValidacaoFechamento("ValidaDiferencaTotalHoraDiaLancamentoMacacao", id);

                if (ResultFechamento.Count > 0)
                {
                    return View("ValidarFechamento", _mapper.Map<List<ViewModelFechamento>>(ResultFechamento));
                }
                else
                {
                    marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
                    marcacao.Lancamentolist = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula"));
                    var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);

                    var viewModelFechamento = _mapper.Map<ViewModelFechamento>(fechamento.CalcularFechamento(marcacao.Lancamentolist.OrderBy(c => c.DateLancamento), jornadaTrabalho));
                    viewModelFechamento.CodigoMarcacao = id;
                    return View("Fechamento", viewModelFechamento);
                }
            }
            catch (Exception e)
            {
                TempData["Createfalse"] = e.Message;
                return View();
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Fechamento(ViewModelFechamento viewModelefechamento)
        {
            try
            {
                Marcacao marcacao = new Marcacao();
                marcacao.ValidaMarcacaoFoiFechada(_marcacaoServiceRepository.ObterMarcacao(viewModelefechamento.CodigoMarcacao));

                string DataFechamento = String.Format("{0:MM/dd/yyyy}", DateTime.Now.ToString());
                var fechamento = _mapper.Map<Fechamento>(viewModelefechamento);
                _fechamentoServiceRepository.SalvarFechamento(fechamento, User.GetDados("Filial"), DataFechamento.ToDateProtheusConvert(), User.GetDados("Matricula"));
                _marcacaoServiceRepository.UpdateStatusFechamento(viewModelefechamento.CodigoMarcacao);
                return Json(new { sucesso = "Fechamento realizado com sucesso!" });
            }
            catch (Exception e)
            {
                return Json(new
                {
                    msg = e.Message,
                    erro = true
                });
            }

        }



        public List<Fechamento> ValidacaoFechamento(string metodo, string id)
        {
            List<Fechamento> listFechamento = new List<Fechamento>();
            Fechamento fechamento = new Fechamento();

            //Mit Validação 8.4.1
            if (metodo == "ValidarApontamentoImpar")
            {
                var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());

                foreach (Lancamento lancamento in listLancamento)
                {
                       
                        var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), lancamento.DateLancamento);
                        var fechamentoReturn = fechamento.ValidarApontamentoImpar(lancamento, listApontamento);

                        if (fechamentoReturn.Divergencia != null)
                        {
                            listFechamento.Add(fechamentoReturn);
                        }

                   
                }
            }

            //Mit Validação 8.4.2
            if (metodo == "ValidaDiferencaTotalHoraDiaLancamentoMacacao")
            {
                 listFechamento  =  ValidaDiferencaTotalHoraDiaLancamentoMacacao(id);
            }


            return listFechamento;
        }


        private List<Fechamento> ValidaDiferencaTotalHoraDiaLancamentoMacacao(string id)
        {
            Fechamento fechamento = new Fechamento();
            List<Fechamento> listFechamento = new List<Fechamento>();

            var listLancamento = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());
            
            foreach (Lancamento lancamento in listLancamento)
            {
                var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), lancamento.DateLancamento);
                var totalApontamentoPorLancentoDia = fechamento.CalcularTotalApontamentoPorDiaLancamento(listApontamento);
                var lancamentolist = _lancamentoerviceRepository.ObterLancamento(lancamento.DateLancamento, User.GetDados("Matricula"));
                var totalHoraDecimalLancmanetoPorDia = fechamento.CalcularTotalHoraLancamentoPorDia(lancamentolist);
                var FechamentoResultValidacao = fechamento.ValidaDiferencaTotalHoraDiaLancamentoTotalApontamento(lancamento, totalHoraDecimalLancmanetoPorDia, totalApontamentoPorLancentoDia);
                if(FechamentoResultValidacao.Descricao != null)
                {
                    listFechamento.Add(FechamentoResultValidacao);
                }

            }
            return listFechamento;
        }

    }

    public class LancamentoComparer : IEqualityComparer<Lancamento>
    {
        public bool Equals(Lancamento x, Lancamento y) => x.DateLancamento == y.DateLancamento;
        public int GetHashCode(Lancamento obj) => obj.DateLancamento.GetHashCode();
    }
}