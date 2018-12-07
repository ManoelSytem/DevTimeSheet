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

        public IEnumerable<Configuracao> ObterListConfiguracao()
        {
            return configRepository.FindAll().ToList();
        }

        Configuracao IConfiguracao.ObterConfiguracaoPorCodigo(string id)
        {
            throw new NotImplementedException();
        }
    }
}
