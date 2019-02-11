using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.ViewModel;

namespace TimeSheet.Models
{
    public class Apontamento
    {
        public TimeSpan hora { get; set; }
        public List<ViewModelLancamento> listLancamento { get; set; }
        public Apontamento()
        {
            this.hora = TimeSpan.Parse("08:00:00");
        }
    }
}
