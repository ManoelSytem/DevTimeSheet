using System;


namespace TimeSheet.ViewModel
{
    public class ViewModelCadastroHora
    {
        public string Codigo { get; set; }
        public string DescJornada { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int JornadaDiaria { get; set; }
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
                throw new Exception("Horários se encontra divergênte! Favor verificar.");
            if (!(this.HoraInicioAte > this.HoraInicioDe && HoraInicioAte < this.HoraFinal))
                throw new Exception("Horários se encontra divergênte! Favor verificar.");
            if (!(this.HoraFinal > this.HoraInicioDe && this.HoraFinal > this.HoraInicioAte))
                throw new Exception("Horários se encontra divergênte! Favor verificar.");

        }
    }
}
