using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Application.Interface
{
    public interface IFechamentoNegocio
    {
        List<Fechamento> CalcularLancamentoPorProjeto(IEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho, Configuracao configura, string matricula, string filial, string codmarcacao);
        List<Fechamento> CalcularTotalHoraExedenteETrabalhadaEabonoeFaltaPorDia(List<Lancamento> listlancamentoDiario, Configuracao config, JornadaTrabalho jornada, string matricula, string filial, string codmarcacao);
        Fechamento CalcularTotalGeralMensalPorDia(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada, Configuracao config, string matricula, string filial,string codmarcacao);
        int CalcularQuantidadeDeDiaSemApontamento(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada);
        int CalcularTotalDeAbono(IOrderedEnumerable<Lancamento> lancamentoList, Configuracao config);
        double CalcularTotalHoras(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada);
        List<Fechamento> ValidaDiasSemLancamento(List<Lancamento> lancamentolist, Marcacao marcacao, string filial);
        List<Fechamento> ValidaDiasComLancamento(List<Lancamento> lancamentolist, Marcacao marcacao, string filial);
        bool ValidaEferiado(string data, string filial);
        bool DatanaoExiste(DateTime data, List<Lancamento> lancamentolist);
        bool DataLancamentoExiste(DateTime data, List<Lancamento> lancamentolist);
        Fechamento ValidarApontamentoImpar(Fechamento fechamento, List<Apontamento> apontamento);
        bool VerificaImpar(List<Apontamento> apontamento);
        decimal CalcularTotalApontamentoPorDiaLancamento(List<Apontamento> apontamentolist, List<Lancamento> listlancamento);
        TimeSpan CalcularTotalHoraLancamentoPorDia(List<Lancamento> lancamento);
        List<Fechamento> ValidaSeExisteMarcacaoAntesEdepoisDoApontamento(List<Lancamento> listlancamento, List<Apontamento> apontamentolist);
        Fechamento ValidaPrimeiroLancamento(Lancamento lancamento, List<Apontamento> apontamentolist);
        Fechamento ValidaUltimoLancamento(Lancamento lancamento, List<Apontamento> apontamentolist);
        Fechamento ValidaDiferencaEntreJornadaDiariaETotalLancamentoDiario(List<Lancamento> lancamento, decimal totalLancamento, JornadaTrabalho jornada);
        Fechamento ValidaSabadoDomingoFeriadoComApontamento(Lancamento lancamento, Feriado feriado);
        Fechamento ValidarLancamentoForaDeJornadaInicio(Lancamento lancamento, JornadaTrabalho jornada);
        Fechamento ValidarUltimoLancamentoForaDeJornada(Lancamento lancamento, JornadaTrabalho jornada);
        Fechamento ValidarLancamentoForaDeIntervaloInicio(Lancamento lancamento, JornadaTrabalho jornada);
        double CalcularTotalGeral(List<Fechamento> listFecahamento);
        Fechamento ValidaSemApontamentoRelogioExiste(List<Apontamento> listApontamento, string dataDia);
        double CalcularTotalHoraExedentes(List<Lancamento> lancamento);
        double CalcularTotalHoraExedentesSemCodigo(List<Lancamento> lancamento, JornadaTrabalho jornada);
        Fechamento ValidarDiferencaHorasExcedentes(double TotalhorasExedentesComCodigo, double TotalhorasExedentesSemCodigo, string datalancamento, JornadaTrabalho jornada);
        double CalcularTotalAbonoGeral(List<Fechamento> listFecahamento);
        double CalcularTotalNaoTrabalhadaGeral(List<Fechamento> listFecahamento);
        double CalcularTotalExedenteGeral(List<Fechamento> listFecahamento);
    }
}
