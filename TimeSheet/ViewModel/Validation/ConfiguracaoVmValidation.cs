using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.ViewModel.Validation
{
    public class ConfiguracaoVmValidation : AbstractValidator<ViewModelConfiguracao>
    {

        public ConfiguracaoVmValidation()
        {
            //Aqui adicionamos as validações de entrada
            RuleFor(x => x.DiaMesLimiteFecha)
                .NotEmpty().WithMessage("* obrigatório");


            RuleFor(x => x.Qtddiadatafechamento)
                           .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.DiaInicio)
                          .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.CodDivergencia)
                          .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.DiaFim)
                    .NotEmpty().WithMessage("* obrigatório");

            RuleFor(x => x.AssuntoEmail)
              .NotEmpty().WithMessage("descreva o assunto email.")
              .Length(1,250).WithMessage("O campo nome deve ter entre 1 e 250 caracteres");

            RuleFor(c => c.TextoEmail)
             .NotEmpty().WithMessage("descreva o texto email.")
             .Length(1, 1000).WithMessage("O campo texto email deve ter entre 1 e 1000 caracteres");

        }
        //Aqui criamos uma validação customizada
        private static bool ClienteMaiorDeIdade(DateTime dataNascimento)
        {
            return dataNascimento <= DateTime.Now.AddYears(-18);
        }
    }
}
