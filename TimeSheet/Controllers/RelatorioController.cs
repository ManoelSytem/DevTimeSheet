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
using TimeSheet.Application;
using TimeSheet.Application.Interface;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
    [Authorize]
    public class RelatorioController : Controller
    {

        private readonly IProtheus _protheusService;
        private readonly IConfiguracao _configuracao;
        private readonly IMarcacao _marcacao;
        private readonly ILancamento _lancamentoerviceRepository;
        private readonly IMarcacao _marcacaoServiceRepository;
        private readonly IMapper _mapper;
        private readonly IJornadaTrabalho _jornadaTrbServiceRepository;
        private readonly IFechamento _fechamentoService;
        private readonly ILancamentoNegocio _lancamentoNegocio;
        private readonly IFechamentoNegocio _fechamentoNegocio;


        public RelatorioController(IFechamento 
            fechamentoService, 
            IProtheus prothuesService, 
            IMarcacao marcacaoServiceRepository,
            IMapper mapper,
            IConfiguracao configuracao, 
            IMarcacao marcacao, 
            ILancamento lancamento, IJornadaTrabalho jornada, ILancamentoNegocio lancamentoNegocio, IFechamentoNegocio fechamentoNegocio)
        {
            _protheusService = prothuesService;
            _marcacaoServiceRepository = marcacaoServiceRepository;
            _mapper = mapper;
            _configuracao = configuracao;
            _marcacao = marcacao;
            _lancamentoerviceRepository = lancamento;
            _jornadaTrbServiceRepository = jornada;
            _fechamentoService = fechamentoService;
            _lancamentoNegocio = lancamentoNegocio;
            _fechamentoNegocio = fechamentoNegocio;


        }
       
        public IActionResult EspelhoDePonto(string id)
        {
            try
            {
                Fechamento fechamento = new Fechamento();
                Marcacao marcacao = new Marcacao();
                ViewModelMacacao viewModelMarcacao = new ViewModelMacacao();
                ViewModelRelatorio viewModelRelatorio = new ViewModelRelatorio();
                List<Apontamento> listaApontamento = new List<Apontamento>();
                Usuario user = new Usuario();


                user = _protheusService.ObterUsuarioNome(User.GetDados("Matricula"));
                user.Nome = user.Nome;
                user.SubjectId = User.GetDados("Matricula");
                user.Gerencia = User.GetDados("Coordenacao");

                viewModelMarcacao =_mapper.Map<ViewModelMacacao>(_marcacao.ObterMarcacao(id));
                viewModelMarcacao.AnoMesDescricao = ObterMesAnoDaMarcacao(viewModelMarcacao);
                viewModelRelatorio.marcacao = viewModelMarcacao;
                viewModelRelatorio.status = viewModelMarcacao.Status;
                viewModelRelatorio.FechamentoPorDatalancamento = _mapper.Map<List<ViewModelFechamento>>(CalcularFechamentoPorData(id).Distinct(new FechamentoComparer()));
                viewModelRelatorio.user = user;         
                viewModelRelatorio.apontamento = ListaApontamentoPorLancamentoEfechamento(_mapper.Map<List<ViewModelLancamento>>(_lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula"))),id);
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

       
        public IActionResult EspelhoDePontoSintetico(string id)
        {
            try
            {

                ViewModelRelatorio viewModelRelatorio = new ViewModelRelatorio();
                Usuario user = new Usuario();
                ViewModelMacacao viewModelMarcacao = new ViewModelMacacao();

                user = _protheusService.ObterUsuarioNome(User.GetDados("Matricula"));
                user.Nome = user.Nome;
                user.SubjectId = User.GetDados("Matricula");
                user.Gerencia = User.GetDados("Coordenacao");

                viewModelMarcacao = _mapper.Map<ViewModelMacacao>(_marcacao.ObterMarcacao(id));
                viewModelMarcacao.AnoMesDescricao = ObterMesAnoDaMarcacao(viewModelMarcacao);
                viewModelRelatorio.marcacao = viewModelMarcacao;
                viewModelRelatorio.status = viewModelMarcacao.Status;
                viewModelRelatorio.FechamentoPorDatalancamento = _mapper.Map<List<ViewModelFechamento>>(CalcularFechamentoPorData(id).Distinct(new FechamentoComparer()));
                viewModelRelatorio.user = user;
                viewModelRelatorio.totalGeral = _fechamentoNegocio.CalcularTotalGeral(_mapper.Map<List<Fechamento>>(viewModelRelatorio.FechamentoPorDatalancamento));
                viewModelRelatorio.totalAbono = _fechamentoNegocio.CalcularTotalAbonoGeral(_mapper.Map<List<Fechamento>>(viewModelRelatorio.FechamentoPorDatalancamento));
                viewModelRelatorio.totalExcedente = _fechamentoNegocio.CalcularTotalExedenteGeral(_mapper.Map<List<Fechamento>>(viewModelRelatorio.FechamentoPorDatalancamento));
                viewModelRelatorio.totalNaoTrabalhada = _fechamentoNegocio.CalcularTotalNaoTrabalhadaGeral(_mapper.Map<List<Fechamento>>(viewModelRelatorio.FechamentoPorDatalancamento));
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

        public IActionResult EspelhoDePontoSinteticoVisaoGerencia(string id)
        {
            try
            {

                ViewModelRelatorio viewModelRelatorio = new ViewModelRelatorio();
                Usuario user = new Usuario();
                ViewModelMacacao viewModelMarcacao = new ViewModelMacacao();

                viewModelMarcacao = _mapper.Map<ViewModelMacacao>(_marcacao.ObterMarcacao(id));
                viewModelMarcacao.AnoMesDescricao = ObterMesAnoDaMarcacao(viewModelMarcacao);
                viewModelRelatorio.marcacao = viewModelMarcacao;
                viewModelRelatorio.status = viewModelMarcacao.Status;
                viewModelRelatorio.FechamentoPorDatalancamento = _mapper.Map<List<ViewModelFechamento>>(CalcularFechamentoPorDataGerencia(id, viewModelRelatorio.marcacao.MatUsuario, viewModelRelatorio.marcacao.Filial).Distinct(new FechamentoComparer()));
                viewModelRelatorio.user = user;

                viewModelRelatorio.totalGeral = _fechamentoNegocio.CalcularTotalGeral(_mapper.Map<List<Fechamento>>(viewModelRelatorio.FechamentoPorDatalancamento));
                viewModelRelatorio.totalAbono = _fechamentoNegocio.CalcularTotalAbonoGeral(_mapper.Map<List<Fechamento>>(viewModelRelatorio.FechamentoPorDatalancamento));
                viewModelRelatorio.totalExcedente = _fechamentoNegocio.CalcularTotalExedenteGeral(_mapper.Map<List<Fechamento>>(viewModelRelatorio.FechamentoPorDatalancamento));
                viewModelRelatorio.totalNaoTrabalhada = _fechamentoNegocio.CalcularTotalNaoTrabalhadaGeral(_mapper.Map<List<Fechamento>>(viewModelRelatorio.FechamentoPorDatalancamento));

                user = _protheusService.ObterUsuarioNome(viewModelRelatorio.marcacao.MatUsuario);
                user.Nome = user.Nome;
                user.SubjectId = viewModelRelatorio.marcacao.MatUsuario;
                user.Gerencia = User.GetDados("Coordenacao");
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
        public IActionResult EspelhoDePontoVisaoGerencia(string id)
        {
            try
            {
                Fechamento fechamento = new Fechamento();
                Marcacao marcacao = new Marcacao();
                ViewModelMacacao viewModelMarcacao = new ViewModelMacacao();
                ViewModelRelatorio viewModelRelatorio = new ViewModelRelatorio();
                List<Apontamento> listaApontamento = new List<Apontamento>();
                Usuario user = new Usuario();

                viewModelMarcacao = _mapper.Map<ViewModelMacacao>(_marcacao.ObterMarcacao(id));
                viewModelMarcacao.AnoMesDescricao = ObterMesAnoDaMarcacao(viewModelMarcacao);
                viewModelRelatorio.marcacao = viewModelMarcacao;
                viewModelRelatorio.status = viewModelMarcacao.Status;
                viewModelRelatorio.FechamentoPorDatalancamento = _mapper.Map<List<ViewModelFechamento>>(CalcularFechamentoPorDataGerencia(id, viewModelRelatorio.marcacao.MatUsuario, viewModelRelatorio.marcacao.Filial).Distinct(new FechamentoComparer()));
                viewModelRelatorio.apontamento = ListaApontamentoPorLancamentoGerencia(_mapper.Map<List<ViewModelLancamento>>(_lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, viewModelRelatorio.marcacao.MatUsuario)), viewModelRelatorio.marcacao.MatUsuario, viewModelRelatorio.marcacao.Filial,id);

                user = _protheusService.ObterUsuarioNome(viewModelRelatorio.marcacao.MatUsuario);
                user.Nome = user.Nome;
                user.SubjectId = viewModelRelatorio.marcacao.MatUsuario;
                user.Gerencia = User.GetDados("Coordenacao");
                viewModelRelatorio.user = user;

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

        private List<Apontamento> ListaApontamentoPorLancamentoEfechamento(List<ViewModelLancamento> listlancamentoViewModel, string codmarcacao)
        {
            List<Apontamento> listaApontamento = new List<Apontamento>();
            string datalancamento = "0";

            //
            foreach (ViewModelLancamento lancamento in listlancamentoViewModel.OrderBy(x => x.DateLancamento))
            {

                if (datalancamento != lancamento.DateLancamento)
                {

                    var listApontamento = _protheusService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), lancamento.DateLancamento);
                    datalancamento = lancamento.DateLancamento;
                    if(listApontamento.Count > 0) {
                    foreach (Apontamento apontamentoResult in listApontamento)
                    {
                        Apontamento novo = new Apontamento();
                        List<Lancamento> listaLancamentoPorApontamento = new List<Lancamento>();
                        novo.dataApontamento = datalancamento.ToDateProtheusReverseformate();
                        novo.apontamento = apontamentoResult.apontamento;
                        foreach (ViewModelLancamento listaLacamento in listlancamentoViewModel.OrderBy(x => x.DateLancamento))
                        {
                            if (novo.dataApontamento == listaLacamento.DateLancamento.ToDateProtheusReverseformate())
                            {
                                if (!listaLancamentoPorApontamento.Contains(_mapper.Map<Lancamento>(listaLacamento),new ComparerDados()))
                                    listaLancamentoPorApontamento.Add(_mapper.Map<Lancamento>(listaLacamento));
                            }
                        }
                        novo.listLancamento = listaLancamentoPorApontamento;
                        listaApontamento.Add(novo);
                     }

                    }
                    else
                    {
                        
                            Apontamento novo = new Apontamento();
                            List<Lancamento> listaLancamentoPorApontamento = new List<Lancamento>();
                            novo.dataApontamento = datalancamento.ToDateProtheusReverseformate();
                            foreach (ViewModelLancamento listaLacamento in listlancamentoViewModel.OrderBy(x => x.DateLancamento))
                            {
                                if (novo.dataApontamento == listaLacamento.DateLancamento.ToDateProtheusReverseformate())
                                {
                                    if (!listaLancamentoPorApontamento.Contains(_mapper.Map<Lancamento>(listaLacamento), new ComparerDados()))
                                        listaLancamentoPorApontamento.Add(_mapper.Map<Lancamento>(listaLacamento));
                                }
                            }
                            novo.listLancamento = listaLancamentoPorApontamento;
                            listaApontamento.Add(novo);
                        
                    }

                }

            }

           
            var listlancamento = _mapper.Map<List<Lancamento>>(listlancamentoViewModel);
            var marcacao = _marcacao.ObterMarcacao(codmarcacao);
            var jornada = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);
            var listDiasSemLancamento = _lancamentoNegocio.ObterDiasSemLancamento(listlancamento.Distinct(new LancamentoComparer()).ToList(), marcacao, User.GetDados("Filial"), jornada);
            foreach (Fechamento fachamento in listDiasSemLancamento.OrderBy(x => x.DataLancamento))
            {
                    var listApontamento = _protheusService.ObterBatidasDePonto(User.GetDados("Matricula"), User.GetDados("Filial"), fachamento.DataLancamento);
                    if (listApontamento.Count > 0) {
                    foreach (Apontamento apontamentoResult in listApontamento) { 
                        Apontamento novo = new Apontamento();
                        List<Lancamento> listaLancamentoPorApontamento = new List<Lancamento>();
                        novo.dataApontamento = fachamento.DataLancamento.ToDateProtheusReverseformate();
                        novo.apontamento = apontamentoResult.apontamento;
                        listaApontamento.Add(novo);
                    }
                }
                else
                {
                    Apontamento novo = new Apontamento();
                    List<Lancamento> listaLancamentoPorApontamento = new List<Lancamento>();
                    novo.dataApontamento = fachamento.DataLancamento.ToDateProtheusReverseformate();
                    listaApontamento.Add(novo);
                }

            }
            return listaApontamento;
        }

        private List<Fechamento> CalcularFechamentoPorData(string id)
        {

            List<Fechamento> listaFechamentoPorData = new List<Fechamento>();
            Marcacao marcacao = new Marcacao();
        
            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var listdeLancamentoMensal = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, User.GetDados("Matricula")).Distinct(new LancamentoComparer());
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);
            var configuracao = _configuracao.ObterConfiguracao();
            listaFechamentoPorData = _lancamentoNegocio.CalcularLancamentoPorData(listdeLancamentoMensal,jornadaTrabalho, configuracao, User.GetDados("Matricula"), User.GetDados("Filial"), id);
             
            return listaFechamentoPorData;
        }

        private string ObterMesAnoDaMarcacao(ViewModelMacacao marcacaoViewModel)
        {
            var mes = marcacaoViewModel.AnoMes.ToString().Substring(4, 2);
            var ano = marcacaoViewModel.AnoMes.ToString().Substring(0, 4);
            string month = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(Convert.ToInt32(mes));
            return char.ToUpper(month[0]) + month.Substring(1) + "/" + ano; ;
        }

        private List<Apontamento> ListaApontamentoPorLancamentoGerencia(List<ViewModelLancamento> listlancamentoViewModel, string matriculaColaborador,string filial, string codMarcacao)
        {
            List<Apontamento> listaApontamento = new List<Apontamento>();
            string datalancamento = "0";

            foreach (ViewModelLancamento lancamento in listlancamentoViewModel.OrderBy(x => x.DateLancamento))
            {

                if (datalancamento != lancamento.DateLancamento)
                {

                    var listApontamento = _protheusService.ObterBatidasDePonto(matriculaColaborador, filial, lancamento.DateLancamento);
                    datalancamento = lancamento.DateLancamento;
                    if (listApontamento.Count > 0)
                    {
                        foreach (Apontamento apontamentoResult in listApontamento)
                        {
                            Apontamento novo = new Apontamento();
                            List<Lancamento> listaLancamentoPorApontamento = new List<Lancamento>();
                            novo.dataApontamento = datalancamento.ToDateProtheusReverseformate();
                            novo.apontamento = apontamentoResult.apontamento;
                            foreach (ViewModelLancamento listaLacamento in listlancamentoViewModel.OrderBy(x => x.DateLancamento))
                            {
                                if (novo.dataApontamento == listaLacamento.DateLancamento.ToDateProtheusReverseformate())
                                {
                                    if (!listaLancamentoPorApontamento.Contains(_mapper.Map<Lancamento>(listaLacamento), new ComparerDados()))
                                        listaLancamentoPorApontamento.Add(_mapper.Map<Lancamento>(listaLacamento));
                                }
                            }
                            novo.listLancamento = listaLancamentoPorApontamento;
                            listaApontamento.Add(novo);
                        }

                    }
                    else
                    {

                        Apontamento novo = new Apontamento();
                        List<Lancamento> listaLancamentoPorApontamento = new List<Lancamento>();
                        novo.dataApontamento = datalancamento.ToDateProtheusReverseformate();
                        foreach (ViewModelLancamento listaLacamento in listlancamentoViewModel.OrderBy(x => x.DateLancamento))
                        {
                            if (novo.dataApontamento == listaLacamento.DateLancamento.ToDateProtheusReverseformate())
                            {
                                if (!listaLancamentoPorApontamento.Contains(_mapper.Map<Lancamento>(listaLacamento), new ComparerDados()))
                                    listaLancamentoPorApontamento.Add(_mapper.Map<Lancamento>(listaLacamento));
                            }
                        }
                        novo.listLancamento = listaLancamentoPorApontamento;
                        listaApontamento.Add(novo);

                    }

                }

            }

            var listlancamento = _mapper.Map<List<Lancamento>>(listlancamentoViewModel);
            var marcacao = _marcacao.ObterMarcacao(codMarcacao);
            var jornada = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);
            var listDiasSemLancamento = _lancamentoNegocio.ObterDiasSemLancamento(listlancamento.Distinct(new LancamentoComparer()).ToList(), marcacao, User.GetDados("Filial"), jornada);
            foreach (Fechamento fachamento in listDiasSemLancamento.OrderBy(x => x.DataLancamento))
            {
                var listApontamento = _protheusService.ObterBatidasDePonto(matriculaColaborador, filial, fachamento.DataLancamento);
                if (listApontamento.Count > 0)
                {
                    foreach (Apontamento apontamentoResult in listApontamento)
                    {
                        Apontamento novo = new Apontamento();
                        List<Lancamento> listaLancamentoPorApontamento = new List<Lancamento>();
                        novo.dataApontamento = fachamento.DataLancamento.ToDateProtheusReverseformate();
                        novo.apontamento = apontamentoResult.apontamento;
                        listaApontamento.Add(novo);
                    }
                }
                else
                {
                    Apontamento novo = new Apontamento();
                    List<Lancamento> listaLancamentoPorApontamento = new List<Lancamento>();
                    novo.dataApontamento = fachamento.DataLancamento.ToDateProtheusReverseformate();
                    listaApontamento.Add(novo);
                }

            }

            return listaApontamento;
        }

        private List<Fechamento> CalcularFechamentoPorDataGerencia(string id, string matriculaColaborador, string filial)
        {

            List<Fechamento> listaFechamentoPorData = new List<Fechamento>();
            Marcacao marcacao = new Marcacao();

            marcacao = _marcacaoServiceRepository.ObterMarcacao(id);
            var listdeLancamentoMensal = _lancamentoerviceRepository.ObterListaLancamentoPorCodMarcacoEMatricula(id, matriculaColaborador).Distinct(new LancamentoComparer());
            var jornadaTrabalho = _jornadaTrbServiceRepository.ObterJornadaPorCodigo(marcacao.codigojornada);
            var configuracao = _configuracao.ObterConfiguracao();
            listaFechamentoPorData = _lancamentoNegocio.CalcularLancamentoPorData(listdeLancamentoMensal, jornadaTrabalho, configuracao, matriculaColaborador, filial, id);

            return listaFechamentoPorData;
        }


    }


    public class ComparerDados : IEqualityComparer<Lancamento>
    {
        public bool Equals(Lancamento x, Lancamento y)
        {
            return (x.HoraInicio.Equals(y.HoraInicio)) &&
                (x.HoraFim.Equals(y.HoraFim));
        }

        public int GetHashCode(Lancamento obj)
        {
            return 0;
        }
    }

    public class FechamentoComparer : IEqualityComparer<Fechamento>
    {
        public bool Equals(Fechamento x, Fechamento y) => x.DataLancamento== y.DataLancamento;
        public int GetHashCode(Fechamento obj) => obj.DataLancamento.GetHashCode();
    }

}