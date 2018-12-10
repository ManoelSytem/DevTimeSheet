using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
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
            return configRepository.Find();
        }

        Configuracao IConfiguracao.ObterConfiguracaoPorCodigo(string id)
        {
            throw new NotImplementedException();
        }

        public void AtualizarConfiguracao(Configuracao config)
        {
            configRepository.Update(config);
        }

        public void DeleteConfiguracao(Configuracao configuracao)
        {
            configRepository.Remove(configuracao.Codigo);
        }
    }
}
