using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Domain;
using TimeSheet.ViewModel;

namespace TimeSheet.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Configuracao, ViewModelConfiguracao>().ReverseMap();
        }

    }
}
