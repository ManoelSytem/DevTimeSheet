using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Rotativa.AspNetCore;
using TimeSheet.Domain;
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
                ViewModelMacacao viewModelMarcacao = new ViewModelMacacao();
                ViewModelRelatorio viewModelRelatorio = new ViewModelRelatorio();
                Usuario user = new Usuario();
               

                user = _prothuesService.ObterUsuarioNome(User.GetDados("Matricula"));
                user.Nome = user.Nome;
                user.SubjectId = User.GetDados("Matricula");
                user.Gerencia = User.GetDados("Coordenacao");

                viewModelMarcacao.AnoMesDescricao = ObterMesAnoDaMarcacao(_mapper.Map<ViewModelMacacao>(_marcacao.ObterMarcacao(id)));
                viewModelRelatorio.marcacao = viewModelMarcacao;
                viewModelRelatorio.Fechamento = CalcularQuantidadeDeDiverGencia(id,_mapper.Map<ViewModelFechamento>(_fechamentoServiceRepository.ObterFechamento(id, User.GetDados("Matricula"))));
                viewModelRelatorio.listLancamento = _mapper.Map<List<Lancamento>, List<ViewModelLancamento>>(_lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")));
                viewModelRelatorio.user = user;
                viewModelRelatorio.apontamento = ListaApontamentoPorLancamento(viewModelRelatorio.listLancamento);


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

        [Authorize]
        public IActionResult EspelhoDePontoSintetico(string id)
        {
            try
            {
              
                ViewModelRelatorio viewModelRelatorio = new ViewModelRelatorio();
                Usuario user = new Usuario();
                ViewModelMacacao viewModelMarcacao = new ViewModelMacacao();

                user = _prothuesService.ObterUsuarioNome(User.GetDados("Matricula"));
                user.Nome = user.Nome;
                user.SubjectId = User.GetDados("Matricula");
                user.Gerencia = User.GetDados("Coordenacao");

                viewModelMarcacao.AnoMesDescricao = ObterMesAnoDaMarcacao(_mapper.Map<ViewModelMacacao>(_marcacao.ObterMarcacao(id)));
                viewModelRelatorio.marcacao = viewModelMarcacao;
                viewModelRelatorio.Fechamento = CalcularQuantidadeDeDiverGencia(id, _mapper.Map<ViewModelFechamento>(_fechamentoServiceRepository.ObterFechamento(id, User.GetDados("Matricula"))));
                viewModelRelatorio.user = user;


                return new ViewAsPdf("EspelhoDePontoSintetico", viewModelRelatorio);
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


        private List<Apontamento> ListaApontamentoPorLancamento(List<ViewModelLancamento> listlancamentoViewModel)
        {
            List<Apontamento> listaApontamento = new List<Apontamento>();
            string datalancamento = "0";

            foreach (ViewModelLancamento lancamento in listlancamentoViewModel.OrderBy(x => x.DateLancamento))
            {
                if (datalancamento != lancamento.DateLancamento)
                {
                    var listApontamento = _prothuesService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), lancamento.DateLancamento);
                    datalancamento = lancamento.DateLancamento;
                    foreach (Apontamento apontamentoResult in listApontamento)
                    {
                        Apontamento novo = new Apontamento();
                        novo.dataApontamento = datalancamento.ToDateProtheusReverseformate();
                        novo.apontamento = apontamentoResult.apontamento;
                        listaApontamento.Add(novo);
                    }

                }

            }

            return listaApontamento;
        }

        private  string ObterMesAnoDaMarcacao(ViewModelMacacao marcacaoViewModel)
        {
            var mes = marcacaoViewModel.AnoMes.ToString().Substring(4, 2);
            var ano = marcacaoViewModel.AnoMes.ToString().Substring(0, 4);
            string month = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(Convert.ToInt32(mes));
            return char.ToUpper(month[0]) + month.Substring(1) + "/" + ano; ;
        }


        private ViewModelFechamento CalcularQuantidadeDeDiverGencia(string id, ViewModelFechamento fechamento)
        {
            int total = 0;
            Configuracao config = new Configuracao();
            config = _configuracao.ObterConfiguracao();
            foreach(Lancamento lancamento in _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")))
            {
                if (lancamento.CodDivergencia == Convert.ToInt16(config.CodDivergencia))
                {
                    total++;
                }
            }
            fechamento.Divergencia = Convert.ToString(total);
            return fechamento;
        }
    }

}