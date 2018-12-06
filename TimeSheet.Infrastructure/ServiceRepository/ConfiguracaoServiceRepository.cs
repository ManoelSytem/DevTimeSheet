using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class ConfiguracaoServiceRepository : IConfiguracao
    {
        private readonly ConfiguracaoRepository configRepository;

        public ConfiguracaoServiceRepository(IConfiguration configuration)
        {
            configRepository = new ConfiguracaoRepository(configuration);
        }


        public Task<Domain.Configuracao> ObterConfiguracaoPorUsuario(string matUser)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Configuracao> ObterConfiguracaoPorCodigo(string id)
        {
            return configRepository.FindAll().ToList();
        }

        public void SalvarConfiguracao(Configuracao config)
        {
           
        }
    }
}
