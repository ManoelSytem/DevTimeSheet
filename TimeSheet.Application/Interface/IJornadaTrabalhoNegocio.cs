using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Application.Interface
{
    public interface IJornadaTrabalhoNegocio
    {
        JornadaTrabalho ObterListaJornadaPorData(string data);
    }
}
