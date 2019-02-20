using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Application.Interface
{
    public interface ILancamentoNegocio
    {
       List<Fechamento> CalcularLancamentoPorData(IEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho, Configuracao configura, string matricula, string filial);
       List<Fechamento> CalcularTotalHoraExedenteETrabalhadaEabono(IEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada, Configuracao config, string matricula, string filial);
       double CalcularTotalLancamentoPorDia(List<Lancamento> listlancamentoDiario);
       double CalcularTotaAbono(Lancamento lancamento, Configuracao config);
       bool Eabono(Lancamento lancamento, Configuracao config);
       List<Fechamento> ValidaDiasSemLancamento(List<Lancamento> lancamentolist, Marcacao marcacao, string filial);
       bool ValidaEferiado(string data, string filial);
       bool DatanaoExiste(DateTime data, List<Lancamento> lancamentolist);
       bool DataLancamentoExiste(DateTime data, List<Lancamento> lancamentolist);

    }
}
