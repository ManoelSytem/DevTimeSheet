﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain.Enty;


namespace TimeSheet.ViewModel
{
    public class ViewModelRelatorio
    {
        public ViewModelFechamento Fechamento { get; set;}
        public List<ViewModelLancamento> listLancamento { get; set; }
        public List<Apontamento> apontamento { get; set; }
        public ViewModelMacacao marcacao { get; set; }
        public Usuario user { get; set; }
    }
}
