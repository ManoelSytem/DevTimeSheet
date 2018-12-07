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

        public void SalvarConfiguracao(Configuracao config)
        {
            configRepository.Add(config);
        }

        public Configuracao ObterConfiguracao()
        {
            return configRepository.FindAll().ToList().First();
        }

        Configuracao IConfiguracao.ObterConfiguracaoPorCodigo(string id)
        {
            throw new NotImplementedException();
        }

        public void AtualizarConfiguracao(Configuracao config)
        {
            configRepository.Update(config);
        }
    }
}
