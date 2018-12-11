using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty.Interface
{
    public interface IProtheus
    {
        IEnumerable<CodDivergencia> ObterListCodDivergenciaPordescricao(string cod);
        CodDivergencia ObterCodigoDivergenciaPorContigo(int cod);
        Usuario ObterMatriculaUserPorCentroCusto(string centroCusto);
    }
}
