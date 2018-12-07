using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty.Interface;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class ProtheusServiceRepository : IProtheus
    {
        public CodDivergencia ObterCodigoDivergenciaPorContigo(int cod)
        {
            throw new NotImplementedException();
        }

        public List<CodDivergencia> ObterListCodDivergenciaPorCod(int cod)
        {
            throw new NotImplementedException();
        }
    }
}
