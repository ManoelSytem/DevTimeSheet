using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty
{
    public class JornadaTrabalho
    {
        public string Codigo { get; set; }
        public string DescJornada { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double JornadaDiaria { get; set; }
        public TimeSpan HoraInicioDe { get; set; }
        public TimeSpan HoraInicioAte { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public TimeSpan InterInicio { get; set; }
        public TimeSpan InterFim { get; set; }
        public TimeSpan InterMin { get; set; }
        public TimeSpan InterMax { get; set; }

        public string ValidarJornadaTrabalhoExisteParaLancamento(List<JornadaTrabalho> jornadalist, string data)
        {
            string codigo ="";
            foreach (JornadaTrabalho JornadaResult in jornadalist)
            {
                if (JornadaResult.DataInicio <= Convert.ToDateTime(data) && JornadaResult.DataFim >= Convert.ToDateTime(data))
                {
                    codigo = JornadaResult.Codigo;
                }
                

            }

            if (codigo == "")
            {
                throw new Exception("Não existe jornada para a data informada! favor verificar.");
            }
               
            return codigo;
        }
    }

    public class JornadaTrabalhoDb
    {
        public string Codigo { get; set; }
        public string DescJornada { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double JornadaDiaria { get; set; }
        public string HoraInicioDe { get; set; }
        public string HoraInicioAte { get; set; }
        public string HoraFinal { get; set; }
        public string InterInicio { get; set; }
        public string InterFim { get; set; }
        public string InterMin { get; set; }
        public string InterMax { get; set; }
    }
}
