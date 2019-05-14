using System;
using System.ComponentModel.DataAnnotations;

namespace TimeSheet.ViewModel
{
    public class ViewModelCadastroHora
    {
        public string Codigo { get; set; }
        public string Filial { get; set; }
        public string DescJornada { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? DataInicio { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? DataFim { get; set; }
        public TimeSpan JornadaDiaria { get; set; }
        public TimeSpan JornadaMin { get; set; }
        public TimeSpan JornadaMax { get; set; }
        public TimeSpan HoraInicioDe { get; set; }
        public TimeSpan HoraInicioAte { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public TimeSpan InterInicio { get; set; }
        public TimeSpan InterFim { get; set; }
        public TimeSpan InterMin { get; set; }
        public TimeSpan InterMax { get; set; }


        public ViewModelCadastroHora()
        {
           
        }

        public void ValidaHorario()
        {
            if(!(this.HoraInicioDe < this.HoraInicioAte && HoraInicioDe < this.HoraFinal))
                throw new Exception("Horários se encontra divergênte! Favor verificar");
        }

        public void ValidaIntervalo()
        {
            if (!(this.InterInicio >= this.HoraInicioAte && this.InterInicio < HoraFinal))
                throw new Exception("Intervalos se encontra divergênte com os Horários informados! Favor verificar");
            if (!(this.InterFim > this.HoraInicioAte && this.InterFim < this.HoraFinal))
                throw new Exception("Intervalos se encontra divergênte com os Horários informados! Favor verificar");
            if (!(this.InterInicio < this.InterFim))
                throw new Exception("Intervalos se encontra divergênte! Favor verificar");
            if (!(this.InterMin < this.InterMax && this.InterMax <= calcularIntervalo()))
                throw new Exception("Mínimo e Máximo se encontra fora do intervalo! Favor verificar");
        }

        public void ValidaJornadaDiaria()
        {
            if (!(this.JornadaMax.Hours <= 24))
                throw new Exception("Total jornada diária maior que "+this.JornadaDiaria+"hs!Favor verificar");
            if (this.JornadaMin > this.JornadaMax)
                throw new Exception("Jornada mínima deve ser menor quer a jornada máxima! Favor verificar");  
            if (this.JornadaMin > this.JornadaDiaria)
                throw new Exception("Jornada mínima maior quer a jornada diária! Favor verificar");
            if (this.JornadaMax < this.JornadaDiaria)
                throw new Exception("Jornada máxima menor que a jornada diária! Favor verificar");
        }

        public void ValidaJornadaMax()
        {
            if (!(this.JornadaDiaria.Hours <= 24))
                throw new Exception("Total jornada diária maior que " + this.JornadaDiaria + "hs!Favor verificar");
            if (!(this.JornadaMax > this.JornadaMin))
                throw new Exception("Jornada máxima deve ser maior quer a jornada mínima! Favor verificar");
        }

        public void ValidaData()
        {
            if (!(this.DataInicio < this.DataFim))
                throw new Exception("Período da jornada se encontra incorreto! Favor verificar");
        }
        public TimeSpan calcularIntervalo()
        {
            TimeSpan intervalo =  this.InterFim - this.InterInicio;

            return intervalo;
        }

        public double calcularJornadaDiaria()
        {
            TimeSpan total;
            double hours;

            TimeSpan jrDiariaM = this.HoraInicioAte - this.HoraInicioDe;
            TimeSpan jrDiariaT =  this.HoraFinal - this.InterFim;

            total = jrDiariaM + jrDiariaT;
            hours = total.TotalHours;
            return  hours;
        }
    }
}
