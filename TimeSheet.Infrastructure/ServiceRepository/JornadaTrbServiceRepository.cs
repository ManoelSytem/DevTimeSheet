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
            _jornadaTrbRepository.Update(item);
        }

        public void DeleteJornada(string codigo)
        {
            _jornadaTrbRepository.Remove(codigo);
        }

        public JornadaTrabalho ObterJornadaPorCodigo(string codigo)
        {
            return _jornadaTrbRepository.FindByID(codigo);
        }

        public List<JornadaTrabalho> ObterListJornada()
        {
            return _jornadaTrbRepository.FindAll();
        }

        public JornadaTrabalho ObterJornadaPorData(string data)
        {
            throw new NotImplementedException();
        }
    }
}
