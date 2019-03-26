using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Util;

namespace TimeSheet.ViewModel
{
    public class ViewModelLancamento
    {
        public string Codigo { get; set; }
        public string Seq { get; set; }
        public string CodLancamento { get; set; }
        public string DateLancamento { get; set; }
        [Required(ErrorMessage = "Hora Início é obrigatório.", AllowEmptyStrings = false)]
        public TimeSpan? HoraInicio { get; set; }
        [Required(ErrorMessage = "Hora Fim é obrigatório. ", AllowEmptyStrings = false)] 
        public TimeSpan? HoraFim { get; set; }
        public string codEmpredimento { get; set; }
        public string DescricaoEmp { get; set; }
        [StringLength(64, MinimumLength = 0, ErrorMessage = "campo observação máximo 60 caracteres")]
        public string Observacao { get; set; }
        public int? CodObservacao { get; set; }
        public int? CodDivergencia { get; set; }
        [Required(ErrorMessage = "Informe o projeto, item obrigatório. ", AllowEmptyStrings = false)]
        public string[] EmpreendimentoIds { get; set; }
        public string[] Usuarios { get; set; }
        public virtual ICollection<Empreendimento> Projetos { get; set; }
        public string Fase { get; set; }
        public string DateFormatado { get { return DateLancamento?.ToDateProtheusReverseformate(); } set { } }
        public string DescricaoCodDiv { get; set; }

        public void ValidaHoraLancamento()
        {
            if (!(this.HoraInicio < this.HoraFim ))
                throw new Exception("Hora lançamento encontra-se divergênte! Favor verificar.");
           
        }


        public void ValidaHorasLancamentoOutraMarcacao(List<Lancamento> listlancamentoRelizado)
        {
            foreach (Lancamento LancamentoResult in listlancamentoRelizado)
            {
                if (LancamentoResult.Seq != this.Seq)
                {
                    if (!(this.HoraInicio >= LancamentoResult.HoraFim || this.HoraInicio <= LancamentoResult.HoraInicio && this.HoraFim <= LancamentoResult.HoraInicio))
                        throw new Exception("Não pode existir horas sobrepostas para o mesmo dia.");
                }
            }

        }


    }
}

