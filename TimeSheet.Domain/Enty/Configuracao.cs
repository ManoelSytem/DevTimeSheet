using System;
using System.Collections.Generic;

namespace TimeSheet.Domain
{
    public class Configuracao
    {
        public string Codigo { get; set; }
        public string FilialProtheus { get; set; }
        public string MatriculaUsuario { get; set; }
        public int DiaMesLimiteFecha { get; set; }
        public int Frequencia_email { get; set; }
        public string AssuntoEmail { get; set; }
        public string TextoEmail { get; set; }
        public int Qtddiadatafechamento { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFim { get; set; }
        public string CodDivergencia { get; set; }


        public void ValidaConfiguracaoMarcacao(string dataAbertura, string dia)
        {
            if(!(Convert.ToDateTime(dataAbertura) <= DateTime.Now & Convert.ToInt32(dia) >= this.DiaInicio & Convert.ToInt32(dia) <= this.DiaFim))
            {
                throw new Exception("Data fora do período! Favor verificar.");
            }
        }

    }

    public class CodDivergencia
    {
        public int? codigo { get; set; }
        public string Descricao { get; set; }
        public string Constant { get; set; }
    }
}
