using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty.Interface
{
    public interface IProtheus
    {
        List<CodDivergencia> ObterListCodDivergenciaPorCod(int cod);
        CodDivergencia ObterCodigoDivergenciaPorContigo(int cod);
        
    }
}
