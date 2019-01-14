using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty.Interface
{
    public interface IProtheus
    {
        IEnumerable<CodDivergencia> ObterListCodDivergenciaPordescricao(string descricao);
        CodDivergencia ObterCodigoDivergenciaPorCodigo(string cod);
        Usuario ObterMatriculaUserPorCentroCusto(string centroCusto);
        IEnumerable<Empreendimento> ObterListEmpreendimentos(string nome);
    }
}
