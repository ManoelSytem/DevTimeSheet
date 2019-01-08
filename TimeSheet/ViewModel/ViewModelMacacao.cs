using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.ViewModel
{
    public class ViewModelMacacao
    {
        public string Filial { get; set; }
        public string Codigo { get; set; }
        public DateTime DataDia { get; set; }
        public string NomeUsuario { get; set; }
        public string NomeGerencia { get; set; }
        public string MatUsuario { get; set; }
        public string CentroCusto { get; set; }
        public string MesAno { get; set; }
        public string Status { get; set; }

        public ViewModelMacacao()
        {
            this.MatUsuario = "01";
        }
    }

}
