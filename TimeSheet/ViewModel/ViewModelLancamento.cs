using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain.Enty;

namespace TimeSheet.ViewModel
{
    public class ViewModelLancamento
    {
        public string Codigo { get; set; }
        public string Seq { get; set; }
        public string CodLancamento { get; set; }
        public string DateLancamento { get; set; }
        [Required(ErrorMessage = "Hora Inicio é obrigatório.", AllowEmptyStrings = false)]
        public TimeSpan? HoraInicio { get; set; }
        [Required(ErrorMessage = "Hora Fim é obrigatório. ", AllowEmptyStrings = false)] 
        public TimeSpan? HoraFim { get; set; }
        public string codEmpredimento { get; set; }
        public string DescricaoEmp { get; set; }
        public string Observacao { get; set; }
        public int? CodObservacao { get; set; }
        public int? CodDivergencia { get; set; }
        [Required(ErrorMessage = "Informe o projeto, item obrigatório. ", AllowEmptyStrings = false)]
        public string[] EmpreendimentoIds { get; set; }
        public virtual ICollection<Empreendimento> Projetos { get; set; }


        public void ValidaHoraLancamento()
        {
            if (!(this.HoraInicio < this.HoraFim ))
                throw new Exception("Hora lançamento encontra-se divergênte! Favor verificar.");
           
        }

    }
}
