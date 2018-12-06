using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.ViewModel
{
    public class ViewModelConfiguracao
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Dia mês limite informado  incorreto.", AllowEmptyStrings = false)]
        public int DiaMesLimiteFecha { get; set; }

        [Required(ErrorMessage = "Selecione a frquência de envio do email.")]
        public int Frequencia_email { get; set; }

        [Required(ErrorMessage = "A quantidade de dias informada é inválida.", AllowEmptyStrings = false)]
        public int Qtddiadatafechamento { get; set; }

        [Required(ErrorMessage = "Dia ínicio ínválido.", AllowEmptyStrings = false)]
        public int DiaInicio { get; set; }

        [Required(ErrorMessage = "Dia fim ínválido.", AllowEmptyStrings = false)]
        public int DiaFim { get; set; }

        [Required(ErrorMessage = "Observação campo assunto", AllowEmptyStrings = false)]
        [StringLength(250, MinimumLength = 1)]
        public string AssuntoEmail { get; set; }

        [Required(ErrorMessage = "Observação campo texto", AllowEmptyStrings = false)]
        [StringLength(1000, MinimumLength = 1)]
        public string TextoEmail { get; set; }

        [Required(ErrorMessage = "Informe o código de divergência", AllowEmptyStrings = false)]
        public int CodDivergencia { get; set; }
        

        public  List<CodDivergencia> ListCodDivergencia { get; set; }


        public ViewModelConfiguracao()
        {
            this.DiaInicio = 16;
            this.DiaFim = 30;
            this.CodDivergencia = 218;
        }

    }


    public class CodDivergencia
    {
        public int codigo { get; set; }
        public string Descricao { get; set; }
    }
}
