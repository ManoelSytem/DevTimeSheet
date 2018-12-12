using System;
using System.Collections.Generic;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class ProtheusServiceRepository : IProtheus
    {
        private readonly ProtheusRepository _prothuesRepository;

        public ProtheusServiceRepository()
        {
            _prothuesRepository = new ProtheusRepository();
        }

        public CodDivergencia ObterCodigoDivergenciaPorContigo(int cod)
        {
            return _prothuesRepository.ObterCodigoDivergenciaPorContigo(cod);
        }

        public IEnumerable<CodDivergencia> ObterListCodDivergenciaPordescricao(string descricao)
        {
            return _prothuesRepository.ObterListaCodigoDivergenciaPorIdDesc(descricao);
        }

        public Usuario ObterMatriculaUserPorCentroCusto(string centroCusto)
        {
            throw new NotImplementedException();
        }
    }
}
