using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Domain.Interface
{
    public interface IFechamento
    {
        void SalvarFechamento(Fechamento item, string filial, string dataProtheus, string matUser, string centroCusto, string projeto, string status, string fase);
        Fechamento ObterFechamento(string codigoMarcacao, string matricula);
        void SalvarFechamentoPorProjeto(List<Fechamento> item, string filial, string dataProtheus, string matUser, string centroCusto,string status);
        IEnumerable<Fechamento> ObterListFechamentoMensalPorMarcacaoDataColoborador(string matricula, string codmarcao);
        void SalvarFechamentoPorDia(List<Fechamento> itens, string filial, string dataProtheus, string matUser, string centroCusto, string status);
        IEnumerable<Fechamento> ObterListFechamentoMensalPorDia(string matricula, string codmarcao);
    }
}
