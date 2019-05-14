using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty
{
    public class JornadaTrabalho
    {
        public string Codigo { get; set; }
        public string Filial { get; set; }
        public string DescJornada { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public TimeSpan JornadaDiaria { get; set; }
        public TimeSpan JornadaMax { get; set; }
        public TimeSpan JornadaMin { get; set; }
        public string   JornadaMinDia { get; set; }
        public string   JornadaDia { get; set; }
        public string   JornadaMaxDia { get; set; }
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


        public void ValidarJornadaTrabalhoSobreposta(List<JornadaTrabalho> jornadalist)
        {
            foreach (JornadaTrabalho JornadaResult in jornadalist)
            {
                if (JornadaResult.DataInicio <= this.DataInicio && JornadaResult.DataFim >= this.DataInicio)
                {
                    throw new Exception("Jornada sobreposta! Já existe jornada de trabalho para o período informado.");
                }

                if(this.DataInicio < JornadaResult.DataInicio)
                {
                    if (!(this.DataFim < JornadaResult.DataInicio))
                    {
                        throw new Exception("Jornada sobreposta! Já existe jornada de trabalho para o período informado.");
                    }
                }
                else
                {
                    if (!(this.DataFim > JornadaResult.DataFim))
                    {
                        throw new Exception("Jornada sobreposta! Já existe jornada de trabalho para o período informado.");
                    }

                }

            }
        }
    }

    public class JornadaTrabalhoDb
    {
        public string Codigo { get; set; }
        public string Filial { get; set; }
        public string DescJornada { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string JornadaDiaria { get; set; }
        public string JornadaMax { get; set; }
        public string JornadaMin { get; set; }
        public string HoraInicioDe { get; set; }
        public string HoraInicioAte { get; set; }
        public string HoraFinal { get; set; }
        public string InterInicio { get; set; }
        public string InterFim { get; set; }
        public string InterMin { get; set; }
        public string InterMax { get; set; }
    }
}
