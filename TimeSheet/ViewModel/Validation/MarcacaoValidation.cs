using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.ViewModel.Validation
{
    public class MarcacaoValidation : AbstractValidator<ViewModelMacacao>
    {
        public MarcacaoValidation()
        {
            RuleFor(x => x.Lancamento.HoraInicio)
                              .NotEmpty().WithMessage("Hora Inicio é obrigatório. ");

            RuleFor(x => x.Lancamento.HoraFim)
                                   .NotEmpty().WithMessage("Hora Fim é obrigatório. ");

            RuleFor(x => x.Lancamento.codEmpredimento)
                                   .NotEmpty().WithMessage("Informe o projeto, item obrigatório.");
        }
    }
}
