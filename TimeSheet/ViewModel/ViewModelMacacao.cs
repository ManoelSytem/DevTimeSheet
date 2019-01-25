using System.Collections.Generic;

namespace TimeSheet.ViewModel
{
    public class ViewModelMacacao
    {

       
        public string Filial { get; set; }
        public string Codigo { get; set; }
        public string DataDia { get; set; }
        public string NomeUsuario { get; set; }
        public string MatUsuario { get; set; }
        public string Coordenacao { get; set; }
        public string AnoMes { get; set; }
        public string AnoMesDescricao { get; set; }
        public string Status { get; set; }
        public string CodLancamento { get; set; }
        public string codigojornada { get; set; }
        public virtual ViewModelLancamento Lancamento { get; set; }
        public virtual List<ViewModelLancamento> Lancamentolist { get; set; }


    }
}
