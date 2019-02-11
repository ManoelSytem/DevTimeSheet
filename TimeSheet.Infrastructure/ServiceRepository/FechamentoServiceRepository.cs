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

        public Fechamento ObterFechamento(string codigoMarcacao, string matricula)
        {
           return _FechamentoRepository.ObterListaFechamentoPorMatriculaEMarcacao(codigoMarcacao,matricula);
        }

        public void SalvarFechamento(Fechamento item, string filial, string dataProtheus, string matUser, string centroCusto, string projeto, string status, string fase)
        {
            _FechamentoRepository.Add(item, filial, dataProtheus, matUser, centroCusto, projeto, status, fase);
        }
    }
}
