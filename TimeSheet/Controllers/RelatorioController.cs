using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    public class RelatorioController : Controller
    {

        private readonly IProtheus _prothuesService;
        private readonly IConfiguracao _configuracao;
        private readonly IMarcacao _marcacao;
        private readonly ILancamento _lancamentoerviceRepository;
        private readonly IMarcacao _marcacaoServiceRepository;
        private readonly IMapper _mapper;
        private readonly IJornadaTrabalho _jornadaTrbServiceRepository;
        private readonly IFechamento _fechamentoServiceRepository;
       

        public RelatorioController(IFechamento fechamentoServiceRepository, IProtheus prothuesService, IMarcacao marcacaoServiceRepository, IMapper mapper, IConfiguracao configuracao, IMarcacao marcacao, ILancamento lancamento, IJornadaTrabalho jornada)
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
        [Authorize]
        public IActionResult EspelhoDePonto(string id)
        {
            try
            {
                Fechamento fechamento = new Fechamento();
                Marcacao marcacao = new Marcacao();
                ViewModelRelatorio viewModelRelatorio = new ViewModelRelatorio();
                Usuario user = new Usuario();

                viewModelRelatorio.user.SubjectId = User.GetDados("Matricula");
                viewModelRelatorio.user.Gerencia = User.GetDados("Coordenacao");
                 user =  _prothuesService.ObterUsuarioNome(User.GetDados("Matricula"));
                viewModelRelatorio.user.Nome = user.Nome;
               

                var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);
                viewModelRelatorio.listFechamento = _mapper.Map<ViewModelFechamento>(fechamento.CalcularFechamento(marcacao.Lancamentolist.OrderBy(c => c.DateLancamento), jornadaTrabalho));
                viewModelRelatorio.listLancamento = _mapper.Map<List<Lancamento>, List<ViewModelLancamento>>(_lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")));


                return new ViewAsPdf("EspelhoDePonto", viewModelRelatorio);
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
    }
}