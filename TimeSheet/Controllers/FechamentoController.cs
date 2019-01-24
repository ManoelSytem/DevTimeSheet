using System;
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
        
        public FechamentoController(IProtheus prothuesService, IMarcacao marcacaoServiceRepository, IMapper mapper, IConfiguracao configuracao, IMarcacao marcacao, ILancamento lancamento, IJornadaTrabalho jornada)
        {
            _prothuesService = prothuesService;
            _marcacaoServiceRepository = marcacaoServiceRepository;
            _mapper = mapper;
            _configuracao = configuracao;
            _marcacao = marcacao;
            _lancamentoerviceRepository = lancamento;
            _jornadaTrbServiceRepository = jornada;

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

                marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
                marcacao.Lancamentolist = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula"));
                var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);
                fechamento.CalcularFechamento(marcacao.Lancamentolist.OrderBy(c => c.DateLancamento), jornadaTrabalho);

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