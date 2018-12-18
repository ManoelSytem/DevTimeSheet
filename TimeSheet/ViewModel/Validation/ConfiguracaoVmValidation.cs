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
                .NotEmpty().WithMessage("* obrigatório")
                .Must(DiaLimiteMesExiste).WithMessage("Dia calendário não existe");

            RuleFor(x => x.Qtddiadatafechamento)
                           .NotEmpty().WithMessage("* obrigatório")
                           .Must(EmailEnvio).WithMessage("Dia calendário não existe");

            RuleFor(x => x.DiaInicio)
                          .NotEmpty().WithMessage("* obrigatório")
                          .Must(DiaInicio).WithMessage("Dia calendário não existe");

            RuleFor(x => x.CodDivergencia)
                          .NotEmpty().WithMessage("* obrigatório");
                 
            RuleFor(x => x.DiaFim)
                    .NotEmpty().WithMessage("* obrigatório")
                    .Must(DiaFim).WithMessage("Dia calendário não existe"); 

            RuleFor(x => x.AssuntoEmail)
              .NotEmpty().WithMessage("descreva o assunto email.")
              .Length(1,26).WithMessage("O campo assunto deve ter entre 1 e 26 caracteres");

            RuleFor(c => c.TextoEmail)
             .NotEmpty().WithMessage("descreva o texto email.")
             .Length(1, 1000).WithMessage("O campo texto email deve ter entre 1 e 1000 caracteres");

        }
        //Aqui criamos uma validação customizada
        private static bool DiaLimiteMesExiste(int dialimitefechamento)
        {
            return  dialimitefechamento >=1 & dialimitefechamento <= 31;
        }

        private static bool DiaInicio(int dialimitefechamento)
        {
            return dialimitefechamento >= 1 & dialimitefechamento <= 31;
        }

        private static bool DiaFim(int dialimitefechamento)
        {
            return dialimitefechamento >= 1 & dialimitefechamento <= 31;
        }

        private static bool EmailEnvio(int dialimitefechamento)
        {
            return dialimitefechamento >= 1 & dialimitefechamento <= 31;
        }
    }
}
