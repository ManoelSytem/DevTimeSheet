using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain.Enty;
using TimeSheet.Models;

namespace TimeSheet.ViewModel
{
    public class ViewModelRelatorio
    {
        public ViewModelFechamento listFechamento { get; set;}
        public List<ViewModelLancamento> listLancamento { get; set; }
        public List<Models.Apontamento> apontamento { get; set; }
        public Usuario user { get; set; }
    }
}
