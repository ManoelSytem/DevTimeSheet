using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Application.Interface;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Util;

namespace TimeSheet.Application
{
    public class JornadaTrabalhoNegocio : IJornadaTrabalhoNegocio
    {
        private readonly IJornadaTrabalho _jornadaTrbServiceRepository;
        public JornadaTrabalhoNegocio(IJornadaTrabalho jornadaTrabalho)
        {
            _jornadaTrbServiceRepository = jornadaTrabalho;
        }

        public JornadaTrabalho ObterListaJornadaPorData(string data)
        {
            JornadaTrabalho jornadaTrb = new JornadaTrabalho();
            var listaJornadaTrabalho  = _jornadaTrbServiceRepository.ObterListJornada();

            foreach(JornadaTrabalho jornada in listaJornadaTrabalho)
            {
                
                if (Convert.ToDateTime(data.ToDateProtheusReverseformate()) >= jornada.DataInicio && Convert.ToDateTime(data.ToDateProtheusReverseformate()) <= jornada.DataFim)
                {
                    jornada.JornadaDia = jornada.JornadaDiaria.ToString(@"hh\:mm");
                    return jornada;
                }
                
            }
            return jornadaTrb;
        }
    }
}

