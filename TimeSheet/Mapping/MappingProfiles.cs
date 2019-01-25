using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.ViewModel;

namespace TimeSheet.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Configuracao, ViewModelConfiguracao>().ReverseMap();

            CreateMap<CodDivergencia, CodDivergenciaViewModel>().ReverseMap();

            CreateMap<JornadaTrabalho, ViewModelCadastroHora>().ReverseMap();

            CreateMap<Marcacao, ViewModelMacacao > ().ReverseMap();

            CreateMap<Lancamento, ViewModelLancamento>().ReverseMap();

            CreateMap<Apontamento, Apontamento>().ReverseMap();

            CreateMap<Fechamento, ViewModelFechamento>().ReverseMap();
        }

    }
}
