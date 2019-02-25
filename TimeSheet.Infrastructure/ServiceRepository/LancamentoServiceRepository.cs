using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class LancamentoServiceRepository : ILancamento
    {
        private readonly LancamentoRepository _LancamentoRepository;

        public LancamentoServiceRepository()
        {
            _LancamentoRepository = new LancamentoRepository();
        }

        public void AtualizarLancamento(Lancamento item)
        {
            _LancamentoRepository.UpdateLancamento(item);
        }

        public void DeleteLancamento(string sequencia)
        {
            _LancamentoRepository.Delete(sequencia);
        }

        public List<Lancamento> ObterLancamento(string data, string matricula)
        {
            return _LancamentoRepository.ObterListaLancamentoPorDataMatricula(data, matricula);
        }

        public Lancamento ObterLancamentoEdit(string data, string matricula, string codlancamento)
        {
           return _LancamentoRepository.ObterLancamentoEdit(data,matricula, codlancamento);
        }

        public List<Lancamento> ObterListaLancamentoPorCodMarcacoEMatricula(string codMarcacao, string matricula)
        {
            return _LancamentoRepository.ObterListaLancamentoPorCodMarcacao(codMarcacao, matricula);
        }

        public List<Lancamento> ObterListaLancamentoPorCodProjeto(string data, string matricula, string codProjeto)
        {
           return _LancamentoRepository.ObterListaLancamentoPorCodProjeto(data, matricula, codProjeto);
        }

        public void SalvarLancamento(Lancamento item, string filial, string dataProthues)
        {
            _LancamentoRepository.Add(item, filial, dataProthues);
        }
    }
}
