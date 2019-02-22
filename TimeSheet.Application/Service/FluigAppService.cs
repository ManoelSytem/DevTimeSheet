using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Application.Interface;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface.Service;

namespace TimeSheet.Application
{
    public class FluigAppService : IFluigAppService
    {
        private readonly IFluigService Service;
        private readonly IConfiguration Configuration;

        public FluigAppService(IFluigService service,
            IConfiguration configuration)
        {
            Service = service;
            Configuration = configuration;
        }

        public string[][] IniciarProcesso(string userCodFluig, string matricula, string filial, string projeto, string GrupoGerencia, string PoolGrupo)
        {
            var fluigProcess = new FluigProcess()
            {
                Username = Configuration.GetSection("Fluig")["UserName"],
                Password = Configuration.GetSection("Fluig")["Password"],
                UserCordFluig = userCodFluig,
                CompanyId = Convert.ToInt32(Configuration.GetSection("Fluig")["CompanyId"]),
                IdProcesso = Configuration.GetSection("Fluig")["IdProcesso"],
                Atividade = 0,
                Completatarefa = true,
                Gestor = false,
                ColleagueId = new string[] { "Pool:Group:GERENCIA_GETIN" },
                Comment = "",
                CardData = new string[][] {
                    new[] { "txtGrupoGerencia", "Getin" },
                    new[] { "hddFilial", filial },
                    new[] { "hddCodigo", "" }, // CODIGO DA ZYU_CODIGO
                    new[] { "TxtMatricula", matricula },
                    new[] { "hddMatFluig", userCodFluig},
                    //ZY
                }
            };

            return Service.IniciarProcesso(fluigProcess);
        }

        public Usuario ObterUserCodFluig(string email)
        {
           return Service.ObterUserCodPorEmailFluig(email);
        }

        public Fechamento SaveProcessIdFluigFechamento(string processId)
        {
            throw new NotImplementedException();
        }

        public void SaveProcessIdFluigFechamento(string processId, string matricula, string codMarcacao)
        {
            throw new NotImplementedException();
        }

        public Marcacao VerificaExisteFechamentoFluig(string processId, string matricula, string codMarcacao)
        {
            return Service.ObterMarcacaoFechamentoFluig(processId, matricula, codMarcacao);
        }
    }
}
