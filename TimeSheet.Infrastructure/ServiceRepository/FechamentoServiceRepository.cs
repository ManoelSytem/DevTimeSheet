using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class FechamentoServiceRepository : IFechamento
    {
        private readonly FechamentoRepository _FechamentoRepository;

        public FechamentoServiceRepository()
        {
            _FechamentoRepository = new FechamentoRepository();
        }

        public List<Fechamento> ObterFechamento(string data, string matricula)
        {
           return _FechamentoRepository.ObterListaLancamentoPorDataMatricula(data, matricula);
        }

        public void SalvarFechamento(Fechamento item, string filial, string dataProtheus, string matUser)
        {
            _FechamentoRepository.Add(item, filial, dataProtheus, matUser);
        }
    }
}
