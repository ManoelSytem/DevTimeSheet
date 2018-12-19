using System;


namespace TimeSheet.ViewModel
{
    public class ViewModelCadastroHora
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
            if (!(this.JornadaDiaria == calcularJornadaDiaria()))
                throw new Exception("Total jornada diária "+this.JornadaDiaria+"h, Total horário "+calcularJornadaDiaria()+"h! Favor verificar");
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
