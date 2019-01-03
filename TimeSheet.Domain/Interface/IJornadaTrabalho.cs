using System.Collections.Generic;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Domain.Interface
{
    public interface IJornadaTrabalho
    {
        void SalvarJornada(JornadaTrabalho item);
        void AtualizarJornada(JornadaTrabalho item);
        void DeleteJornada(string codigo);
        IEnumerable<JornadaTrabalho> ObterListJornada();
        JornadaTrabalho ObterJornadaPorCodigo(string codigo);
    }
}
