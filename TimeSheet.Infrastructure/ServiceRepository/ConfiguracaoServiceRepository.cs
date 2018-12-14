using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Infrastructure.Repository;


namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class ConfiguracaoServiceRepository : IConfiguracao
    {
        private readonly ConfiguracaoRepository configRepository;
        private static string Local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\", "/").Replace("file:/", "") + "/";
        private static string Arquivo = "textEmail.rdf";

        public ConfiguracaoServiceRepository(IConfiguration configuration)
        {
            configRepository = new ConfiguracaoRepository(configuration);
        }

        public void SalvarConfiguracao(Configuracao config, string filial, string matricula)
        {
            configRepository.Add(config, filial, matricula);
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

        public void DeleteConfiguracao(string codigo)
        {
            configRepository.Remove(codigo);
        }

        public void SalvarTextoEmail(string texto)
        {
            WriteLine(texto);
        }

        public string[] ObterTextoEmail()
        {
           return Leitura();
        }

        public static void WriteLine(string pLine)
        {
            string lLine = string.Empty;
            try
            {
                CreateLog();
                using (StreamWriter file = new StreamWriter(Local + Arquivo, false))
                {
                    lLine = String.Format(pLine);
                    file.WriteLine(lLine);
                    file.Close();
                }
            }
            catch (Exception ex)
            {
              
            }
          
        }

        private static void CreateLog()
        {
            if (!Directory.Exists(Local)) Directory.CreateDirectory(Local);
            if (!File.Exists(Local + Arquivo)) File.Create(Local + Arquivo).Close();
        }


        public string[] Leitura()
        {
            string[] lines = null;
            if (!Directory.Exists(Local+Arquivo))
            {
                lines = File.ReadAllLines(Local+Arquivo);
                return lines;
            }

            return lines;
        }

    }
}
