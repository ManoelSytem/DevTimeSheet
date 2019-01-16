using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Domain.Interface
{
    public interface ILancamento
    {
        void SalvarLancamento(Lancamento item, string filial, string dataProtheus);
        void AtualizarLancamento(Lancamento item);
        void DeleteLancamento(string codigo);
        List<Lancamento> ObterLancamento(string data, string matricula);
        Lancamento ObterLancamentoEdit(string data, string matricula, string codigo);

    }

}
