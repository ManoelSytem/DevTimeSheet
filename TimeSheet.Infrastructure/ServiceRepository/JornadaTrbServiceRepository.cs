using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class JornadaTrbServiceRepository : IJornadaTrabalho
    {

        private readonly JornadaTrabalhoRepository _jornadaTrbRepository;

        public JornadaTrbServiceRepository()
        {
            _jornadaTrbRepository = new JornadaTrabalhoRepository();
        }

        public void SalvarJornada(JornadaTrabalho item)
        {
            _jornadaTrbRepository.Add(item);
        }

        public void AtualizarJornada(JornadaTrabalho item)
        {
            throw new NotImplementedException();
        }

        public void DeleteJornada(string codigo)
        {
            throw new NotImplementedException();
        }

        public JornadaTrabalho ObterJornadaPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JornadaTrabalho> ObterListJornada()
        {
            throw new NotImplementedException();
        }

    }
}
