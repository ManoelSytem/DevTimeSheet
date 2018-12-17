using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.ViewModel.Validation
{
    public class ViewModelCadastroHora
    {
        public string DescJornada { get; set; }
        
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

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
    }
}
