using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class FluigServiceRespository : IFluig
    {
        private readonly RepositoryFluig  _RepositoryFluig;
        public FluigServiceRespository()
        {
            _RepositoryFluig = new RepositoryFluig();
        }

        public Usuario ObterUsuarioFluig(string email)
        {
            return _RepositoryFluig.ObterUsuarioFluigPorEmail(email);
        }
    }
}
