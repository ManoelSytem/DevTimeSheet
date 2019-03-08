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

        public List<Apontamento> ObterBatidasDePonto(string mat, string filial, string Data)
        {
            return _prothuesRepository.ObterListBatidaDePontoDiario(mat, filial, Data);
        }

        public CodDivergencia ObterCodigoDivergenciaPorCodigo(string cod)
        {
            return _prothuesRepository.ObterCodigoDivergenciaPorCodigo(cod);
        }

        public Usuario ObterCoordenadorPorCentroDeCusto(string centroCusto)
        {
            return _prothuesRepository.ObterCoordenador(centroCusto);
        }

        public Feriado ObterFeriadoPorDataLancamento(string data, string filial)
        {
            return _prothuesRepository.ObterFeriadoProthues(data, filial);
        }

        public IEnumerable<CodDivergencia> ObterListCodDivergenciaPordescricao(string descricao)
        {
            return _prothuesRepository.ObterListaCodigoDivergenciaPorIdDesc(descricao);
        }

        public List<Usuario> ObterListColaboradorPorCentroDeCusto(string descricao, string centroCusto)
        {
            return _prothuesRepository.ObterListColaborador(descricao, centroCusto);
        }

        public IEnumerable<Empreendimento> ObterListEmpreendimentos(string nome)
        {
            return _prothuesRepository.ObterEmpreendimentos(nome);
        }

        public Usuario ObterUsuarioNome(string mat)
        {
            return _prothuesRepository.ObterUsuarioPorMatricula(mat);
        }

        public List<Apontamento> ObterApontamentos(string matricula, string filial, string Data) => _prothuesRepository.ObterApontamentos(matricula, filial, Data);

        public CodDivergencia ObterTipoCodigoDivergencia(string codigoDivegencia)
        {
            return _prothuesRepository.ObterTipoCodigoDivergencia(codigoDivegencia);
        }
    }
}
