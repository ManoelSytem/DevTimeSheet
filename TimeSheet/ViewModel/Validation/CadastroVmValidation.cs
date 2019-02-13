using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.ViewModel.Validation
{
    public class CadastroVmValidation : AbstractValidator<ViewModelCadastroHora>
    {
        public CadastroVmValidation()
        {
            RuleFor(x => x.DescJornada)
             .NotEmpty().WithMessage("* obrigatório")
            .Length(1, 30).WithMessage("O campo não deve ser maior que 30 caracteres");

            RuleFor(x => x.Filial)
            .NotEmpty().WithMessage("* obrigatório")
            .Must(ContagemCaractere).WithMessage("Código filial inválido.");

            RuleFor(x => x.DataInicio)
                               .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.DataFim)
                               .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.JornadaDiaria)
                               .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.HoraInicioDe)
                                       .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.HoraInicioAte)
                                       .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.HoraFinal)
                                       .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.InterInicio)
                                       .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.InterFim)
                                       .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.InterFim)
                                       .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.InterMin)
                                       .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.InterMax)
                                      .NotEmpty().WithMessage("* obrigatório");

        }

        private static bool ContagemCaractere(string Filial)
        {
            if(Filial.ToString().Length > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
