using System;
using System.Collections.Generic;
using TimeSheet.Util;

namespace TimeSheet.ViewModel
{
    public class ViewModelMacacao
    {

       
        public string Filial { get; set; }
        public TimeSpan jornadDiaria { get; set; }
        public TimeSpan jornadaMax { get; set; }
        public TimeSpan jornadaMin { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public DateTime? DataDialancamento { get; set; }
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
